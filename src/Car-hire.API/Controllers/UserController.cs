using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/users")]
[ApiController]
[Authorize]
public class UserController : ControllerBase
{
    private readonly IServiceManager _service;

    public UserController(IServiceManager service)
    {
        _service = service;
    }

    [Authorize(Roles = "Admin, User")]
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _service.UserService.GetAllUsersAsync(false);

        return Ok(users);
    }

    [Authorize(Roles = "Admin, User")]
    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUser(int userId)
    {
        var user = await _service.UserService.GetUserAsync(userId, false);

        return Ok(user);
    }

    [Authorize(Roles = "Admin, User")]
    [HttpGet("orders")]
    public async Task<IActionResult> GetUsersOrders([FromQuery] DateTime orderDate)
    {
        var orders = await _service.UserService.GetUsersByOrderDateAsync(orderDate, false);

        return Ok(orders);
    }

    [Authorize(Roles = "Admin, User")]
    [HttpPut("{userId:int}")]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UserForUpdateDto? user)
    {
        if (user is null)
            return BadRequest("UserForUpdateDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.UserService.UpdateUserAsync(userId, user, true);

        return NoContent();
    }

    [Authorize(Roles = "Admin, User")]
    [HttpDelete("{userId:int}")]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        await _service.UserService.DeleteUserAsync(userId, false);
        
        return NoContent();
    }
}