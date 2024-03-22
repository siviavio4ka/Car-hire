using Car_hire.DAL.Entities.DTOs.OrderDTO;

namespace Car_hire.BLL.Contracts;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges);
    Task<OrderDto> GetOrderAsync(int orderId, bool trackChanges);
    Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId, bool trackChanges);
    Task<IEnumerable<OrderWithUserDto>> GetOrdersWithUserAsync(bool trackChanges);
    Task OrderClosingAsync(int orderId, bool orderTrackChanges, bool carTrackChanges);
    Task CreateOrderAsync(OrderForCreationDto order);
    Task UpdateOrderAsync(int orderId, OrderForUpdateDto order, bool trackChanges);
    Task DeleteOrderAsync(int orderId, bool trackChanges);
}