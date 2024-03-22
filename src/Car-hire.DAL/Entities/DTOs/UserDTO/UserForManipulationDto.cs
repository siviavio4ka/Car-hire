using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.UserDTO;

public abstract record UserForManipulationDto
{
    [Required(ErrorMessage = "Name is required field")]
    public string? Name { get; init; }
    [Required(ErrorMessage = "Passport details is required field")]
    [RegularExpression(@"^[A-Z]{2}\d{7}$", ErrorMessage = "Invalid passport details format")]
    public string? PassportDetails { get; init; }
    [Required(ErrorMessage = "Address is required field")]
    public string? Address { get; init; }
    [Required(ErrorMessage = "Phone number is required field")]
    [RegularExpression(@"^\+\d{3} \d{2} \d{7}$|^\+\d{3} \d{3} \d{7}$", ErrorMessage = "Invalid phone number format")]
    public string? PhoneNumber { get; init; }
}