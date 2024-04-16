using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
    {
        var userRoles = IdentityUserRoleGenerator.GenerateIdentityUserRole(30, 4);
        builder.HasData(userRoles);
    }
}