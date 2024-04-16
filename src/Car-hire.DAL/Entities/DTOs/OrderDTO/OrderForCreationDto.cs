using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public record OrderForCreationDto : OrderForManipulationDto
{
    [Required(ErrorMessage = "Order number is required field")]
    [RegularExpression(@"^\d{5}$", ErrorMessage = "Order number must be a 5-digit number")]
    public int OrderNumber { get; init; }
    [Required(ErrorMessage = "Car id is required field")]
    public int CarId { get; init; }
    [Required(ErrorMessage = "User id is required field")]
    public int UserId { get; init; }
}