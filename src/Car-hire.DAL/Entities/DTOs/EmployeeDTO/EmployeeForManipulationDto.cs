using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.EmployeeDTO;

public abstract record EmployeeForManipulationDto
{
    [Required(ErrorMessage = "Name is required field")]
    public string? Name { get; init; }
}