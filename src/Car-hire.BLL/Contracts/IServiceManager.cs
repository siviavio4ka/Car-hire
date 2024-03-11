namespace Car_hire.BLL.Contracts;

public interface IServiceManager
{
    ICarService CarService { get; }
    ICustomerService CustomerService { get; }
    IEmployeeService EmployeeService { get; }
    IOrderService OrderService { get; }
}