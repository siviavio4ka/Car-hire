using Microsoft.AspNetCore.Identity;

namespace Car_hire.DAL.Entities.Models;

public class User : IdentityUser<int>
{
    public string? Name { get; set; }
    public string? PassportDetails { get; set; }
    public string? Address { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public ICollection<Order>? Orders { get; set; }
}