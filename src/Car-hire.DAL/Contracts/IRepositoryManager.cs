namespace Car_hire.DAL.Contracts;

public interface IRepositoryManager
{
    ICarRepository Car { get; }
    ICustomerRepository Customer { get; }
    IOrderRepository Order { get; }
    Task SaveAsync();
}