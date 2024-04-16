using Car_hire.BLL.Auth.Contracts;

namespace Car_hire.BLL.Contracts;

public interface IServiceManager
{
    ICarService CarService { get; }
    IUserService UserService { get; }
    IOrderService OrderService { get; }
    IAuthenticationService AuthenticationService { get; }
    IAuthorizationService AuthorizationService { get; }
}