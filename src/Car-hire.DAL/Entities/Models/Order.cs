namespace Car_hire.DAL.Entities.Models;

public class Order
{
    public int OrderId { get; set; }
    public int OrderNumber { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int HireHours { get; set; }
    public DateTime Deadline { get; set; }
    public double? Amount { get; set; }
}