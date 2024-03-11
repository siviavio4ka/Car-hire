using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(o => o.OrderDate)
            .ToListAsync();

    public async Task<Order> GetOrderAsync(int orderId, bool trackChanges) =>
        await FindByCondition(o => o.OrderId.Equals(orderId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId, bool trackChanges) =>
        await FindByCondition(o => o.CustomerId.Equals(customerId), trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<(string customerName, List<DateTime> orderDates, double totalAmount)>> GetOrdersWithCustomersAsync(bool trackChanges)
    {
        var rentalInfo = await FindAll(trackChanges)
            .Include(o => o.Customer)
            .Select(o => new
            {
                CustomerName = o.Customer.Name,
                OrderDate = o.OrderDate,
                TotalAmount = o.Amount ?? 0
            })
            .ToListAsync();

        var groupedInfo = rentalInfo
            .GroupBy(info => info.CustomerName)
            .Select(group => new
            {
                CustomerName = group.Key,
                OrderDates = group.Select(info => info.OrderDate).ToList(),
                TotalAmount = group.Sum(info => info.TotalAmount)
            });

        return groupedInfo.Select(group =>
            (group.CustomerName, group.OrderDates, group.TotalAmount));
    }

    public void CreateOrder(Order order) => Create(order);

    public void DeleteOrder(Order order) => Delete(order);
}