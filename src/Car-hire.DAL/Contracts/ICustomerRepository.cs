using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges);
    Task<Customer> GetCustomerAsync(int customerId, bool trackChanges);
    Task<IEnumerable<Customer>> GetCustomersByOrderDateAsync(DateTime orderDate, bool trackChanges);
    void CreateCustomer(Customer customer);
    void DeleteCustomer(Customer customer);
}