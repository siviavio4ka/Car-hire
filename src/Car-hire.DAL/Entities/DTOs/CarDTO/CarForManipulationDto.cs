using System.ComponentModel.DataAnnotations;
using Car_hire.DAL.Entities.Enums;

namespace Car_hire.DAL.Entities.DTOs.CarDTO;

public abstract record CarForManipulationDto
{
    [Required(ErrorMessage = "Number is required field")]
    [RegularExpression(@"^\d{4} [A-Z]{2}-[1-6]$", ErrorMessage = "Invalid Number format")]
    public string? Number { get; init; }
    [Required(ErrorMessage = "Brand is required field")]
    [EnumDataType(typeof(Brand), ErrorMessage = "Invalid Brand")]
    public Brand Brand { get; init; }
    [Required(ErrorMessage = "Mileage is required field")]
    [Range(1, int.MaxValue, ErrorMessage = "Mileage must be a non-negative number")]
    public int Mileage { get; init; }
    [Required(ErrorMessage = "Status is required field")]
    [EnumDataType(typeof(Status), ErrorMessage = "Invalid Status")]
    public Status Status { get; init; }
    [Required(ErrorMessage = "Seating capacity is required field")]
    [Range(1, 10, ErrorMessage = "Seating capacity must be between 1 and 10")]
    public int SeatingCapacity { get; init; }
    [Required(ErrorMessage = "Hire price is required field")]
    [Range(1, 9999, ErrorMessage = "Hire price must be between 1 and 9999")]
    public int HirePrice { get; init; }
}