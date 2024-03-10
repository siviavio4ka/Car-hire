using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges);
    Task<Order> GetOrderAsync(int orderId, bool trackChanges);
    Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId, bool trackChanges);
    Task<IEnumerable<(string customerName, DateTime orderDate, double totalAmount)>> GetOrdersWithCustomersAsync(bool trackChanges);
    void CreateOrder(Order order);
    void DeleteOrder(Order order);
}