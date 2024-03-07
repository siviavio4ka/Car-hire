namespace Car_hire.DAL.Entities.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Order>? Orders { get; set; }
}