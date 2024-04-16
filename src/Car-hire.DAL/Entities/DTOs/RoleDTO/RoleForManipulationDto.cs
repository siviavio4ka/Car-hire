using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.RoleDTO;

public abstract record RoleForManipulationDto
{
    [Required(ErrorMessage = "Role name is required field")]
    public string? Name { get; init; }
}