using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var users = UserGenerator.GenerateUser(30, 1000000, 9999999, 100);
        builder.HasData(users);
    }
}