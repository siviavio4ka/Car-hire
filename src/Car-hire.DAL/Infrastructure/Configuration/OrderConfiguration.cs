using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        // builder.HasOne(o => o.User)
        //        .WithMany(c => c.Orders)
        //        .HasForeignKey(o => o.CustomerId)
        //        .HasPrincipalKey(c => c.CustomerId);
        
        var orders = OrderGenerator.GenerateOrder(50, 30, new DateTime(2000, 1, 1, 0, 0, 0), 30, 168);
        builder.HasData(orders);
    }
}