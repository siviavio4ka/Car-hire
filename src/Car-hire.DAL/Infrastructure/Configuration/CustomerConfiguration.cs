using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        var customers = CustomerGenerator.GenerateCustomer(30, 1000000, 9999999, 100);
        builder.HasData(customers);
    }
}