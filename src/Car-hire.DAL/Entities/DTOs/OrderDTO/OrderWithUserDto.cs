namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public record OrderWithUserDto
{
    public string UserName { get; init; }
    public List<DateTime> OrderDates { get; init; }
    public double TotalAmount { get; init; }
}