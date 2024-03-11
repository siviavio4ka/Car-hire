using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.EmployeeDTO;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Services;

internal sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repository = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(bool trackChanges)
    {
        var employees = await _repository.Employee.GetAllEmployeesAsync(trackChanges);
        var employeesDto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return employeesDto;
    }

    public async Task<EmployeeDto> GetEmployeeAsync(int employeeId, bool trackChanges)
    {
        var employee = await _repository.Employee.GetEmployeeAsync(employeeId, trackChanges)
            ?? throw new EmployeeNotFoundException(employeeId);
        
        var employeeDto = _mapper.Map<EmployeeDto>(employee);
        return employeeDto;        
    }

    public async Task CreateEmployeeAsync(EmployeeForCreationDto employee)
    {
        var employeeEntity = _mapper.Map<Employee>(employee);
        _repository.Employee.CreateEmployee(employeeEntity);
        await _repository.SaveAsync();
    }

    public async Task UpdateEmployeeAsync(int employeeId, EmployeeForUpdateDto employee, bool trackChanges)
    {
        var employeeEntity = await _repository.Employee.GetEmployeeAsync(employeeId, trackChanges)
            ?? throw new EmployeeNotFoundException(employeeId);
        
        _mapper.Map(employee, employeeEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteEmployeeAsync(int employeeId, bool trackChanges)
    {
        var employee = await _repository.Employee.GetEmployeeAsync(employeeId, trackChanges)
            ?? throw new EmployeeNotFoundException(employeeId);

        _repository.Employee.DeleteEmployee(employee);
        await _repository.SaveAsync();
    }
}