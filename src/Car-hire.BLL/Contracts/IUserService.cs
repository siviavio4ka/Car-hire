using Car_hire.DAL.Entities.DTOs.UserDTO;

namespace Car_hire.BLL.Contracts;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
    Task<UserDto> GetUserAsync(int userId, bool trackChanges);
    Task<IEnumerable<UserDto>> GetUsersByOrderDateAsync(DateTime orderDate, bool trackChanges);
    Task CreateUserAsync(UserForCreationDto user);
    Task UpdateUserAsync(int userId, UserForUpdateDto user, bool trackChanges);
    Task DeleteUserAsync(int userId, bool trackChanges);
}