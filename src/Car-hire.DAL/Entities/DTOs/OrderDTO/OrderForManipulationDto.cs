using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public abstract record OrderForManipulationDto
{
    [Required(ErrorMessage = "Order number is required field")]
    [RegularExpression(@"^\d{5}$", ErrorMessage = "Order number must be a 5-digit number")]
    public int OrderNumber { get; init; }
    [Required(ErrorMessage = "Car id is required field")]
    public int CarId { get; init; }
    [Required(ErrorMessage = "Order date is required field")]
    public DateTime OrderDate { get; init; }
    [Required(ErrorMessage = "Customer id is required field")]
    public int CustomerId { get; init; }
    [Required(ErrorMessage = "Hire hours is required field")]
    [Range(1, int.MaxValue, ErrorMessage = "Hire hours must be a positive number")]
    public int HireHours { get; init; }
    public DateTime Deadline { get; init; }
    public double? Amount { get; init; }
}