namespace Car_hire.DAL.Contracts;

public interface IRepositoryManager
{
    ICarRepository Car { get; }
    IUserRepository User { get; }
    IOrderRepository Order { get; }
    Task SaveAsync();
}