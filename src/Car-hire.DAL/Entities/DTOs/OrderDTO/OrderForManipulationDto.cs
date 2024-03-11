namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public abstract record OrderForManipulationDto
{
    public int OrderNumber { get; init; }
    public int CarId { get; init; }
    public DateTime OrderDate { get; init; }
    public int EmployeeId { get; init; }
    public int CustomerId { get; init; }
    public int HireHours { get; init; }
    public DateTime Deadline { get; init; }
    public double? Amount { get; init; }
}