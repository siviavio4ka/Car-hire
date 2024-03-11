namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public record OrderWithCustomerDto
{
    public string CustomerName { get; init; }
    public List<DateTime> OrderDates { get; init; }
    public double TotalAmount { get; init; }
}