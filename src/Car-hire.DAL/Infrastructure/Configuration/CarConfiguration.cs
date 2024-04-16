using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public IEnumerable<Car>? Cars { get; set; }
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        Cars = CarGenerator.GenerateCar(30, 99999, 10, 100, 999);
        builder.HasData(Cars);
    }
}