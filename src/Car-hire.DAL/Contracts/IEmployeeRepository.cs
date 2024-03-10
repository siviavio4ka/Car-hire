using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackChanges);
    Task<Employee> GetEmployeeAsync(int employeeId, bool trackChanges);
    void CreateEmployee(Employee employee);
    void DeleteEmployee(Employee employee);
}