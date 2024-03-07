using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Infrastructure.EntityGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_hire.DAL.Infrastructure.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var employees = EmployeeGenerator.GenerateEmployee(10);
        builder.HasData(employees);
    }
}