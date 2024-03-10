using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(e => e.Name)
            .ToListAsync();

    public async Task<Employee> GetEmployeeAsync(int employeeId, bool trackChanges) =>
        await FindByCondition(e => e.EmployeeId.Equals(employeeId), trackChanges)
            .SingleOrDefaultAsync();

    public void CreateEmployee(Employee employee) => Create(employee);

    public void DeleteEmployee(Employee employee) => Delete(employee);
}