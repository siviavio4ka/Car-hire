using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/authentication")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IServiceManager _service;

    public AuthenticationController(IServiceManager service)
    {
        _service = service;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto? user)
    {
        if (user is null)
        {
            return BadRequest("UserForRegistrationDto object is null");
        }
        
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }
        
        var result = await _service.AuthenticationService.RegisterAsync(user);

        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto? user)
    {
        if (user is null)
        {
            return BadRequest("UserForRegistrationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        var result = await _service.AuthenticationService.AuthenticateAsync(user);

        return Ok(result);
    }

    [HttpPost("refresh")]
    public async Task<IActionResult> Refresh([FromBody] TokenDto? token)
    {
        if (token is null)
        {
            return BadRequest("TokenDto object is null");
        }
        
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }
        
        var tokenDto = await _service.AuthenticationService.UpdateTokenAsync(token);

        return Ok(tokenDto);
    }
}