using AutoMapper;
using Car_hire.BLL.Auth.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;
using Car_hire.DAL.Entities.Exceptions.BadRequestException;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace Car_hire.BLL.Auth.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IJwtService _jwtService;

    public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IJwtService jwtService)
    {
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
        _jwtService = jwtService;
    }

    public async Task<UserWithTokenDto> RegisterAsync(UserForRegistrationDto user)
    {
        var userEntity = _mapper.Map<User>(user);

        userEntity.RefreshToken = _jwtService.CreateRefreshToken();
        userEntity.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

        var result = await _userManager.CreateAsync(userEntity, user.Password!);

        if (!result.Succeeded)
            throw new RegistrationBadRequestException();

        var userWithTokenDto = _mapper.Map<UserWithTokenDto>(userEntity);
        userWithTokenDto.Token = await _jwtService.CreateTokenAsync(userEntity);

        return userWithTokenDto;
    }

    public async Task<UserWithTokenDto> AuthenticateAsync(UserForAuthenticationDto user)
    {
        var userEntity = await _userManager.FindByEmailAsync(user.Email!)
            ?? throw new UserNotFoundException(user.Email!);

        var result = await _userManager.CheckPasswordAsync(userEntity, user.Password!);

        if (!result)
            throw new InvalidPasswordBadRequestException();

        userEntity.RefreshToken = _jwtService.CreateRefreshToken();
        userEntity.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

        await _userManager.UpdateAsync(userEntity);

        var userWithTokenDto = _mapper.Map<UserWithTokenDto>(userEntity);
        userWithTokenDto.Token = await _jwtService.CreateTokenAsync(userEntity);

        return userWithTokenDto;
    }

    public async Task<UserWithTokenDto> UpdateTokenAsync(TokenDto token)
    {
        var principal = _jwtService.GetPrincipalFromExpiredToken(token.Token);

        var user = await _userManager.FindByNameAsync(principal.Identity!.Name!);

        if (user is null || user.RefreshToken != token.RefreshToken ||
            user.RefreshTokenExpiryTime <= DateTime.Now)
            throw new RefreshTokenBadRequestException();

        var newToken = await _jwtService.CreateTokenAsync(user!);

        var userWithTokenDto = _mapper.Map<UserWithTokenDto>(user);
        userWithTokenDto.Token = newToken;

        return userWithTokenDto;
    }
}