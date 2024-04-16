using System.Security.Claims;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Auth.Contracts;

public interface IJwtService
{
    Task<string> CreateTokenAsync(User user);
    string CreateRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}