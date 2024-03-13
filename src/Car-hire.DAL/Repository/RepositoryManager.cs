using Car_hire.DAL.Contracts;

namespace Car_hire.DAL.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationContext _applicationContext;
    private readonly Lazy<ICarRepository> _carRepository;
    private readonly Lazy<ICustomerRepository> _customerRepository;
    private readonly Lazy<IOrderRepository> _orderRepository;

    public RepositoryManager(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
        _carRepository = new Lazy<ICarRepository>(() => new CarRepository(applicationContext));
        _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(applicationContext));
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(applicationContext));
    }

    public ICarRepository Car => _carRepository.Value;
    public ICustomerRepository Customer => _customerRepository.Value;
    public IOrderRepository Order => _orderRepository.Value;
    public async Task SaveAsync() => await _applicationContext.SaveChangesAsync();
}