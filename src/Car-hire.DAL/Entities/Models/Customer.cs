namespace Car_hire.DAL.Entities.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PassportDetails { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int DriverLicenceNumber { get; set; }
    public ICollection<Order>? Orders { get; set; }
}