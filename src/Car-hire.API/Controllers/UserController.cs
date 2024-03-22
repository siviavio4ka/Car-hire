using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IServiceManager _service;

    public UserController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _service.UserService.GetAllUsersAsync(false);
        return Ok(users);
    }

    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUser(int userId)
    {
        var user = await _service.UserService.GetUserAsync(userId, false);
        return Ok(user);
    }

    [HttpGet("orders")]
    public async Task<IActionResult> GetUsersOrders([FromQuery] DateTime orderDate)
    {
        var orders = await _service.UserService.GetUsersByOrderDateAsync(orderDate, false);
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto? user)
    {
        if (user is null)
            return BadRequest("UserForCreationDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.UserService.CreateUserAsync(user);
        return Ok();
    }

    [HttpPut("{userId:int}")]
    public async Task<IActionResult> UpdateCustomer(int userId, [FromBody] UserForUpdateDto? user)
    {
        if (user is null)
            return BadRequest("UserForUpdateDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.UserService.UpdateUserAsync(userId, user, true);
        return NoContent();
    }

    [HttpDelete("{userId:int}")]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        await _service.UserService.DeleteUserAsync(userId, false);
        return NoContent();
    }
}