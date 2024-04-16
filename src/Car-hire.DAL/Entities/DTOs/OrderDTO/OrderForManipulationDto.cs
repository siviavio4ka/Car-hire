using System.ComponentModel.DataAnnotations;

namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public abstract record OrderForManipulationDto
{
    [Required(ErrorMessage = "Order date is required field")]
    public DateTime OrderDate { get; init; }
    [Required(ErrorMessage = "Hire hours is required field")]
    [Range(1, int.MaxValue, ErrorMessage = "Hire hours must be a positive number")]
    public int HireHours { get; init; }
}