namespace Car_hire.DAL.Contracts;

public interface IRepositoryManager
{
    ICarRepository Car { get; }
    ICustomerRepository Customer { get; }
    IEmployeeRepository Employee { get; }
    IOrderRepository Order { get; }
    void Save();
}