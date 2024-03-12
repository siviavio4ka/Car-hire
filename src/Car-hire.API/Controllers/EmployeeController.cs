using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.EmployeeDTO;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/employees")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IServiceManager _service;

    public EmployeeController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await _service.EmployeeService.GetAllEmployeesAsync(false);
        return Ok(employees);
    }

    [HttpGet("{employeeId:int}")]
    public async Task<IActionResult> GetEmployee(int employeeId)
    {
        var employee = await _service.EmployeeService.GetEmployeeAsync(employeeId, false);
        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee([FromBody] EmployeeForCreationDto? employee)
    {
        if (employee is null)
            return BadRequest("EmployeeForCreationDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.EmployeeService.CreateEmployeeAsync(employee);
        return Ok();
    }

    [HttpPut("{employeeId:int}")]
    public async Task<IActionResult> UpdateEmployee(int employeeId, [FromBody] EmployeeForUpdateDto? employee)
    {
        if (employee is null)
            return BadRequest("EmployeeForUpdateDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.EmployeeService.UpdateEmployeeAsync(employeeId, employee, true);
        return NoContent();
    }

    [HttpDelete("{employeeId:int}")]
    public async Task<IActionResult> DeleteEmployee(int employeeId)
    {
        await _service.EmployeeService.DeleteEmployeeAsync(employeeId, false);
        return NoContent();
    }
}