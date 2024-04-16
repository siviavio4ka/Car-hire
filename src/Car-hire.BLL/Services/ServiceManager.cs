using AutoMapper;
using Car_hire.BLL.Auth.Contracts;
using Car_hire.BLL.Auth.Services;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace Car_hire.BLL.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICarService> _carService;
    private readonly Lazy<IUserService> _userService;
    private readonly Lazy<IOrderService> _orderService;
    private readonly Lazy<IAuthenticationService> _authenticationService;
    private readonly Lazy<IAuthorizationService> _authorizationService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, 
    UserManager<User> userManager, IJwtService jwtService, RoleManager<Role> roleManager)
    {
        _carService = new Lazy<ICarService>(() => new CarService(repositoryManager, logger, mapper));
        _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
        _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, logger, mapper));
        _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, jwtService));
        _authorizationService = new Lazy<IAuthorizationService>(() => new AuthorizationService(logger, roleManager, userManager, mapper));
    }

    public ICarService CarService => _carService.Value;
    public IUserService UserService => _userService.Value;
    public IOrderService OrderService => _orderService.Value;
    public IAuthenticationService AuthenticationService => _authenticationService.Value;
    public IAuthorizationService AuthorizationService => _authorizationService.Value;
}