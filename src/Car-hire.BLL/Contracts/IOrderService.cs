using Car_hire.DAL.Entities.DTOs.OrderDTO;

namespace Car_hire.BLL.Contracts;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges);
    Task<OrderDto> GetOrderAsync(int orderId, bool trackChanges);
    Task<IEnumerable<OrderDto>> GetOrdersByCustomerIdAsync(int customerId, bool trackChanges);
    Task<IEnumerable<OrderWithCustomerDto>> GetOrdersWithCustomersAsync(bool trackChanges);
    Task CreateOrderAsync(OrderForCreationDto order);
    Task UpdateOrderAsync(int orderId, OrderForUpdateDto order, bool trackChanges);
    Task DeleteOrderAsync(int orderId, bool trackChanges);
}