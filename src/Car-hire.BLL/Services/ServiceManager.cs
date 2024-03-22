using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;

namespace Car_hire.BLL.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICarService> _carService;
    private readonly Lazy<IUserService> _userService;
    private readonly Lazy<IOrderService> _orderService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _carService = new Lazy<ICarService>(() => new CarService(repositoryManager, logger, mapper));
        _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
        _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, logger, mapper));
    }

    public ICarService CarService => _carService.Value;
    public IUserService UserService => _userService.Value;
    public IOrderService OrderService => _orderService.Value;
}