using Microsoft.AspNetCore.Identity;

namespace Car_hire.DAL.Entities.Models;

public class User : IdentityUser
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PassportDetails { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public ICollection<Order>? Orders { get; set; }
}