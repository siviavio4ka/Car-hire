using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasData(
            new Role
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new Role
            {
                Id = 2,
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new Role
            {
                Id = 3,
                Name = "User",
                NormalizedName = "USER"
            }
        );
    }
}