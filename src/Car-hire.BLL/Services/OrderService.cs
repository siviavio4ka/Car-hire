using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.OrderDTO;
using Car_hire.DAL.Entities.Enums;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Services;

internal sealed class OrderService : IOrderService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public OrderService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repository = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges)
    {
        var orders = await _repository.Order.GetAllOrdersAsync(trackChanges);
        var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
        return ordersDto;
    }

    public async Task<OrderDto> GetOrderAsync(int orderId, bool trackChanges)
    {
        var order = await _repository.Order.GetOrderAsync(orderId, trackChanges)
            ?? throw new OrderNotFoundException(orderId);

        var orderDto = _mapper.Map<OrderDto>(order);
        return orderDto;
    }

    public async Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId, bool trackChanges)
    {
        var orders = await _repository.Order.GetOrdersByUserIdAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);

        var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
        return ordersDto;
    }

    public async Task<IEnumerable<OrderWithUserDto>> GetOrdersWithUserAsync(bool trackChanges)
    {
        var ordersWithUsers = await _repository.Order.GetOrdersWithUsersAsync(trackChanges);
        var ordersWithUsersDto = ordersWithUsers
            .Select(oc => new OrderWithUserDto
            {
                UserName = oc.userName,
                OrderDates = oc.orderDates.ToList(),
                TotalAmount = oc.totalAmount
            })
        .ToList();
        return ordersWithUsersDto;
    }
    
    public async Task OrderClosingAsync(int orderId, bool orderTrackChanges, bool carTrackChanges)
    {
        var order = await _repository.Order.GetOrderAsync(orderId, orderTrackChanges)
            ?? throw new OrderNotFoundException(orderId);
        
        var car = await _repository.Car.GetCarAsync(order.CarId, carTrackChanges)
            ?? throw new CarNotFoundException(order.CarId);
        

        car.Status = Status.Available;
        await _repository.SaveAsync();
    }

    public async Task CreateOrderAsync(OrderForCreationDto order)
    {
        var orderEntity = _mapper.Map<Order>(order);
        _repository.Order.CreateOrder(orderEntity);
        await _repository.SaveAsync();
    }

    public async Task UpdateOrderAsync(int orderId, OrderForUpdateDto order, bool trackChanges)
    {
        var orderEntity = await _repository.Order.GetOrderAsync(orderId, trackChanges)
            ?? throw new OrderNotFoundException(orderId);

        _mapper.Map(order, orderEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteOrderAsync(int orderId, bool trackChanges)
    {
        var order = await _repository.Order.GetOrderAsync(orderId, trackChanges)
            ?? throw new OrderNotFoundException(orderId);

        _repository.Order.DeleteOrder(order);
        await _repository.SaveAsync();
    }
}