using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.UserDTO.Auth;

public record UserForAuthenticationDto
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string? Email { get; init; }
    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; init; }
}