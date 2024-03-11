using Car_hire.DAL.Entities.Enums;

namespace Car_hire.DAL.Entities.DTOs.CarDTO;

public abstract record CarForManipulationDto
{
    public string? Number { get; init; }
    public Brand Brand { get; init; }
    public int Mileage { get; init; }
    public Status Status { get; init; }
    public int SeatingCapacity { get; init; }
    public int HirePrice { get; init; }
}