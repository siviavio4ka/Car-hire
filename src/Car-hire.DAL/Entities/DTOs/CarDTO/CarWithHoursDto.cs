namespace Car_hire.DAL.Entities.DTOs.CarDTO;

public record CarWithHoursDto
{
    public CarDto Car { get; init; }
    public int QuantityHours { get; init; }
}