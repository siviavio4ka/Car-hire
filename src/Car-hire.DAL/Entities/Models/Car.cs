using Car_hire.DAL.Entities.Enums;

namespace Car_hire.DAL.Entities.Models;

public class Car
{
    public int CarId { get; set; }
    public string Number { get; set; } = string.Empty;
    public Brand Brand { get; set; }
    public int Mileage { get; set; }
    public Status Status { get; set; }
    public int SeatingCapacity { get; set; }
    public double HirePrice { get; set; }
    public ICollection<Order>? Orders { get; set; }
}