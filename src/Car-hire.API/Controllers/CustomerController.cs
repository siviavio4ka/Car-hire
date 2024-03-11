using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.CustomerDTO;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly IServiceManager _service;

    public CustomerController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _service.CustomerService.GetAllCustomersAsync(false);
        return Ok(customers);
    }

    [HttpGet("{customerId:int}")]
    public async Task<IActionResult> GetCustomer(int customerId)
    {
        var customer = await _service.CustomerService.GetCustomerAsync(customerId, false);
        return Ok(customer);
    }

    [HttpGet("orders")]
    public async Task<IActionResult> GetCustomersOrders([FromQuery] DateTime orderDate)
    {
        var orders = await _service.CustomerService.GetCustomersByOrderDateAsync(orderDate, false);
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto? customer)
    {
        if (customer is null)
            return BadRequest("CustomerForCreationDto object is null");

        await _service.CustomerService.CreateCustomerAsync(customer);
        return Ok();
    }

    [HttpPut("{customerId:int}")]
    public async Task<IActionResult> UpdateCustomer(int customerId, [FromBody] CustomerForUpdateDto? customer)
    {
        if (customer is null)
            return BadRequest("CustomerForUpdateDto object is null");

        await _service.CustomerService.UpdateCustomerAsync(customerId, customer, true);
        return NoContent();
    }

    [HttpDelete("{customerId:int}")]
    public async Task<IActionResult> DeleteCustomer(int customerId)
    {
        await _service.CustomerService.DeleteCustomerAsync(customerId, false);
        return NoContent();
    }
}