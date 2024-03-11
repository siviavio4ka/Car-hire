using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.CustomerDTO;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Services;

internal sealed class CustomerService : ICustomerService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CustomerService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repository = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges)
    {
        var customers = await _repository.Customer.GetAllCustomersAsync(trackChanges);
        var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
        return customersDto;
    }

    public async Task<CustomerDto> GetCustomerAsync(int customerId, bool trackChanges)
    {
        var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges)
            ?? throw new CustomerNotFoundException(customerId);
        
        var customerDto = _mapper.Map<CustomerDto>(customer);
        return customerDto;
    }

    public async Task<IEnumerable<CustomerDto>> GetCustomersByOrderDateAsync(DateTime orderDate, bool trackChanges)
    {
        var customers = await _repository.Customer.GetCustomersByOrderDateAsync(orderDate, trackChanges);
        var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
        return customersDto;
    }

    public async Task CreateCustomerAsync(CustomerForCreationDto? customer)
    {
        var customerEntity = _mapper.Map<Customer>(customer);
        _repository.Customer.CreateCustomer(customerEntity);
        await _repository.SaveAsync();
    }

    public async Task UpdateCustomerAsync(int customerId, CustomerForUpdateDto? customer, bool trackChanges)
    {
        var customerEntity = await _repository.Customer.GetCustomerAsync(customerId, trackChanges)
            ?? throw new CustomerNotFoundException(customerId);
        
        _mapper.Map(customer, customerEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteCustomerAsync(int customerId, bool trackChanges)
    {
        var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges)
            ?? throw new CustomerNotFoundException(customerId);

        _repository.Customer.DeleteCustomer(customer);
        await _repository.SaveAsync();
    }
}