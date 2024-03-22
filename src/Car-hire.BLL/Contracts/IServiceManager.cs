namespace Car_hire.BLL.Contracts;

public interface IServiceManager
{
    ICarService CarService { get; }
    IUserService UserService { get; }
    IOrderService OrderService { get; }
}