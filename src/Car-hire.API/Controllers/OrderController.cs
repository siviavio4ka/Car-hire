using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.OrderDTO;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/orders")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IServiceManager _service;

    public OrderController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var orders = await _service.OrderService.GetAllOrdersAsync(false);
        return Ok(orders);
    }

    [HttpGet("{orderId:int}")]
    public async Task<IActionResult> GetOrder(int orderId)
    {
        var order = await _service.OrderService.GetOrderAsync(orderId, false);
        return Ok(order);
    }

    [HttpGet("customer/{customerId:int}")]
    public async Task<IActionResult> GetOrdersByCustomerId(int customerId)
    {
        var orders = await _service.OrderService.GetOrdersByCustomerIdAsync(customerId, false);
        return Ok(orders);
    }

    [HttpGet("orders-with-customers")]
    public async Task<IActionResult> GetOrdersWithCustomers()
    {
        var orders = await _service.OrderService.GetOrdersWithCustomersAsync(false);
        return Ok(orders);
    }

    [HttpPost("{orderId:int}/close")]
    public async Task<IActionResult> OrderClosing(int orderId)
    {
        await _service.OrderService.OrderClosingAsync(orderId, false, true);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderForCreationDto? order)
    {
        if (order is null)
            return BadRequest("OrderForCreationDto object is null");

        await _service.OrderService.CreateOrderAsync(order);
        return Ok();
    }

    [HttpPut("{orderId:int}")]
    public async Task<IActionResult> UpdateOrder(int orderId, [FromBody] OrderForUpdateDto? order)
    {
        if (order is null)
            return BadRequest("OrderForUpdateDto object is null");

        await _service.OrderService.UpdateOrderAsync(orderId, order, true);
        return NoContent();
    }

    [HttpDelete("{orderId:int}")]
    public async Task<IActionResult> DeleteOrder(int orderId)
    {
        await _service.OrderService.DeleteOrderAsync(orderId, false);
        return NoContent();
    }
}