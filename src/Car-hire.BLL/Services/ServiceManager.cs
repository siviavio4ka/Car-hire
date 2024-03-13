using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;

namespace Car_hire.BLL.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICarService> _carService;
    private readonly Lazy<ICustomerService> _customerService;
    private readonly Lazy<IOrderService> _orderService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _carService = new Lazy<ICarService>(() => new CarService(repositoryManager, logger, mapper));
        _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, logger, mapper));
        _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, logger, mapper));
    }

    public ICarService CarService => _carService.Value;
    public ICustomerService CustomerService => _customerService.Value;
    public IOrderService OrderService => _orderService.Value;
}