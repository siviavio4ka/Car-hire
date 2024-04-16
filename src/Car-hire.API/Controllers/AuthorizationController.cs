using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.RoleDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/authorization")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AuthorizationController : ControllerBase
{
    private readonly IServiceManager _service;

    public AuthorizationController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRoles()
    {
        var roles = await _service.AuthorizationService.GetAllRolesAsync();
        
        return Ok(roles);
    }

    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetRole(int userId)
    {
        var roles = await _service.AuthorizationService.GetUserRolesAsync(userId);

        return Ok(roles);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole([FromBody] RoleForCreationDto? role)
    {
        if (role is null)
            return BadRequest("RoleForCreationDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);
        
        await _service.AuthorizationService.CreateRoleAsync(role);

        return Ok();
    }

    [HttpPut("{roleId:int}")]
    public async Task<IActionResult> UpdateRole(int roleId, [FromBody] RoleForUpdateDto? role)
    {
        if (role is null)
            return BadRequest("RoleForUpdateDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.AuthorizationService.UpdateRoleAsync(roleId, role);

        return NoContent();
    }

    [HttpDelete("{roleId:int}")]
    public async Task<IActionResult> DeleteRole(int roleId)
    {
        await _service.AuthorizationService.DeleteRoleAsync(roleId);

        return NoContent();
    }

    [HttpPost("{userId:int}/set")]
    public async Task<IActionResult> SetUserRoles(int userId, [FromBody] IEnumerable<int> roleIds)
    {
        if (roleIds is null)
            return BadRequest("IEnumerable<int> object is null");

        await _service.AuthorizationService.SetUserRolesAsync(userId, roleIds);

        return NoContent();
    }

    [HttpPost("{userId:int}/remove")]
    public async Task<IActionResult> RemoveUserRoles(int userId, [FromBody] IEnumerable<int> roleIds)
    {
        if (roleIds is null)
            return BadRequest("IEnumerable<int> object is null");

        await _service.AuthorizationService.RemoveUserRolesAsync(userId, roleIds);

        return NoContent();
    }
}