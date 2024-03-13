using Car_hire.DAL.Entities.Enums;
using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.Configuration;
using Car_hire.DAL.Infrastructure.Triggers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Car_hire.DAL;

public class ApplicationContext : DbContext
{
    private readonly IConfiguration _configuration;
    public ApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
        // Database.EnsureCreated();
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

        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}