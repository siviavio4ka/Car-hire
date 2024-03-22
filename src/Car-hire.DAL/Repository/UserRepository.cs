using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

    public async Task<User> GetUserAsync(int userId, bool trackChanges) =>
        await FindByCondition(c => c.UserId.Equals(userId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<User>> GetUsersByOrderDateAsync(DateTime orderDate, bool trackChanges) =>
        await FindByCondition(c => c.Orders.Any(o => o.OrderDate.Date.Equals(orderDate.Date)), trackChanges)
            .ToListAsync();

    public void CreateUser(User user) => Create(user);

    public void DeleteUser(User user) => Delete(user);
}