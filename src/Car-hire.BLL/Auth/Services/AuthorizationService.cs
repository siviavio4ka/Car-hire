using AutoMapper;
using Car_hire.BLL.Auth.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.RoleDTO;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.BLL.Auth.Services;

public class AuthorizationService : IAuthorizationService
{
    private readonly ILoggerManager _logger;
    private readonly RoleManager<Role> _roleManager;
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public AuthorizationService(ILoggerManager logger, RoleManager<Role> roleManager, UserManager<User> userManager, IMapper mapper)
    {
        _logger = logger;
        _roleManager = roleManager;
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
    {
        var roles = await _roleManager.Roles.ToListAsync()
            ?? throw new RoleNotFoundException();

        var rolesDto = _mapper.Map<IEnumerable<RoleDto>>(roles);
        return rolesDto;
    }

    public async Task<IEnumerable<RoleDto>> GetUserRolesAsync(int userId)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new UserNotFoundException(userId);

        var roleNames = await _userManager.GetRolesAsync(user)
                        ?? throw new RoleNotFoundException();

        var roles = await _roleManager.Roles.Where(r => roleNames.Contains(r.Name!)).ToListAsync()
            ?? throw new RoleNotFoundException();

        var rolesDto = _mapper.Map<IEnumerable<RoleDto>>(roles);
        return rolesDto;
    }

    public async Task CreateRoleAsync(RoleForCreationDto role)
    {
        var roleEntity = _mapper.Map<Role>(role);

        await _roleManager.CreateAsync(roleEntity);
    }

    public async Task UpdateRoleAsync(int roleId, RoleForUpdateDto role)
    {
        var roleEntity = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == roleId)
            ?? throw new RoleNotFoundException(roleId);

        _mapper.Map(role, roleEntity);
        await _roleManager.UpdateAsync(roleEntity);
    }

    public async Task DeleteRoleAsync(int roleId)
    {
        var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == roleId)
            ?? throw new RoleNotFoundException(roleId);

        await _roleManager.DeleteAsync(role);
    }

    public async Task SetUserRolesAsync(int userId, IEnumerable<int> roleIds)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new UserNotFoundException(userId.ToString());

        var roles = await _userManager.GetRolesAsync(user)
            ?? throw new RoleNotFoundException();

        foreach (var roleId in roleIds)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == roleId)
                ?? throw new RoleNotFoundException(roleId);

            if (!roles.Contains(role.ToString()))
                await _userManager.AddToRoleAsync(user, role.ToString());
        }
    }

    public async Task RemoveUserRolesAsync(int userId, IEnumerable<int> roleIds)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new UserNotFoundException(userId.ToString());

        var roles = await _userManager.GetRolesAsync(user)
            ?? throw new RoleNotFoundException();

        foreach (var roleId in roleIds)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == roleId)
                ?? throw new RoleNotFoundException(roleId);

            if (roles.Contains(role.ToString()))
                await _userManager.RemoveFromRoleAsync(user, role.ToString());
        }
    }
}