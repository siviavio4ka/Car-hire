using Car_hire.DAL.Entities.Enums;
using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.Configuration;
using Car_hire.DAL.Infrastructure.Triggers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Car_hire.DAL;

public class ApplicationContext : IdentityDbContext<User, Role, int>
{
    private readonly IConfiguration _configuration;
    public ApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionStrings = _configuration.GetConnectionString("SqlConnection") ?? string.Empty;
        optionsBuilder.UseNpgsql(connectionStrings, b => b.MigrationsAssembly("Car-hire.API")).UseTriggers(triggerOptions =>
        {
            triggerOptions.AddTrigger<UpdateCarStatusTrigger>(ServiceLifetime.Transient);
            triggerOptions.AddTrigger<CalculateAmountBeforeTrigger>(ServiceLifetime.Transient);
            triggerOptions.AddTrigger<CalculateDeadlineBeforeTrigger>(ServiceLifetime.Transient);
        });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresEnum<Brand>();
        modelBuilder.HasPostgresEnum<Status>();

        modelBuilder.Entity<Car>()
            .Property(c => c.Brand)
            .HasConversion<string>();

        modelBuilder.Entity<Car>()
            .Property(c => c.Status)
            .HasConversion<string>();

        modelBuilder.Entity<Order>()
            .Property(o => o.OrderDate)
            .HasColumnType("timestamp");

        modelBuilder.Entity<Order>()
            .Property(o => o.Deadline)
            .HasColumnType("timestamp");

        modelBuilder.Entity<User>()
            .Property(u => u.RefreshTokenExpiryTime)
            .HasColumnType("timestamp");

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
}