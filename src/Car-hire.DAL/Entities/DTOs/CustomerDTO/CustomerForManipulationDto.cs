namespace Car_hire.DAL.Entities.DTOs.CustomerDTO;

public abstract record CustomerForManipulationDto
{
    public string? Name { get; init; }
    public string? PassportDetails { get; init; }
    public string? Address { get; init; }
    public string? PhoneNumber { get; init; }
    public int DriverLicenceNumber { get; init; }
}