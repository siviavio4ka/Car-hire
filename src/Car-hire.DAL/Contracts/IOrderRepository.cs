using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges);
    Task<Order> GetOrderAsync(int orderId, bool trackChanges);
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, bool trackChanges);
    Task<IEnumerable<(string userName, List<DateTime> orderDates, double totalAmount)>> GetOrdersWithUsersAsync(bool trackChanges);
    void CreateOrder(Order order);
    void DeleteOrder(Order order);
}