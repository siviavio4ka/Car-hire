using Car_hire.DAL.Entities.DTOs.RoleDTO;

namespace Car_hire.BLL.Auth.Contracts;

public interface IAuthorizationService
{
    Task<IEnumerable<RoleDto>> GetAllRolesAsync();
    Task<IEnumerable<RoleDto>> GetUserRolesAsync(int userId);
    Task CreateRoleAsync(RoleForCreationDto role);
    Task UpdateRoleAsync(int roleId, RoleForUpdateDto role);
    Task DeleteRoleAsync(int roleId);
    Task SetUserRolesAsync(int userId, IEnumerable<int> roleIds);
    Task RemoveUserRolesAsync(int userId, IEnumerable<int> roleIds);
}