namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException(int orderId) 
        : base($"The order with id: {orderId} doesn't exist in the database.")
    {
    }
}