using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

    public async Task<Customer> GetCustomerAsync(int customerId, bool trackChanges) =>
        await FindByCondition(c => c.CustomerId.Equals(customerId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<Customer>> GetCustomersByOrderDateAsync(DateTime orderDate, bool trackChanges) =>
        await FindByCondition(c => c.Orders.Any(o => o.OrderDate.Equals(orderDate)), trackChanges)
            .ToListAsync();

    public void CreateCustomer(Customer customer) => Create(customer);

    public void DeleteCustomer(Customer customer) => Delete(customer);
}