using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
    Task<User> GetUserAsync(int userId, bool trackChanges);
    Task<IEnumerable<User>> GetUsersByOrderDateAsync(DateTime orderDate, bool trackChanges);
    void CreateUser(User user);
    void DeleteUser(User user);
}