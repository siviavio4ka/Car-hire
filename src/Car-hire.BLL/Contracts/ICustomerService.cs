using Car_hire.DAL.Entities.DTOs.CustomerDTO;

namespace Car_hire.BLL.Contracts;

public interface ICustomerService
{
    Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges);
    Task<CustomerDto> GetCustomerAsync(int customerId, bool trackChanges);
    Task<IEnumerable<CustomerDto>> GetCustomersByOrderDateAsync(DateTime orderDate, bool trackChanges);
    Task CreateCustomerAsync(CustomerForCreationDto customer);
    Task UpdateCustomerAsync(int customerId,CustomerForUpdateDto customer, bool trackChanges);
    Task DeleteCustomerAsync(int customerId, bool trackChanges);
}