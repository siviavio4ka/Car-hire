using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;

namespace Car_hire.BLL.Auth.Contracts;

public interface IAuthenticationService
{
    Task<UserWithTokenDto> RegisterAsync(UserForRegistrationDto user);
    Task<UserWithTokenDto> AuthenticateAsync(UserForAuthenticationDto user);
    Task<UserWithTokenDto> UpdateTokenAsync(TokenDto token);
}