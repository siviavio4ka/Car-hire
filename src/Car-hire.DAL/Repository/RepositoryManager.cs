using Car_hire.DAL.Contracts;

namespace Car_hire.DAL.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationContext _applicationContext;
    private readonly Lazy<ICarRepository> _carRepository;
    private readonly Lazy<IUserRepository> _userRepository;
    private readonly Lazy<IOrderRepository> _orderRepository;

    public RepositoryManager(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
        _carRepository = new Lazy<ICarRepository>(() => new CarRepository(applicationContext));
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(applicationContext));
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(applicationContext));
    }

    public ICarRepository Car => _carRepository.Value;
    public IUserRepository User => _userRepository.Value;
    public IOrderRepository Order => _orderRepository.Value;
    public async Task SaveAsync() => await _applicationContext.SaveChangesAsync();
}