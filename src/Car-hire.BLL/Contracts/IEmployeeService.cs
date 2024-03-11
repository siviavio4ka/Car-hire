using Car_hire.DAL.Entities.DTOs.EmployeeDTO;

namespace Car_hire.BLL.Contracts;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(bool trackChanges);
    Task<EmployeeDto> GetEmployeeAsync(int employeeId, bool trackChanges);
    Task CreateEmployeeAsync(EmployeeForCreationDto employee);
    Task UpdateEmployeeAsync(int employeeId, EmployeeForUpdateDto employee, bool trackChanges);
    Task DeleteEmployeeAsync(int employeeId, bool trackChanges);
}