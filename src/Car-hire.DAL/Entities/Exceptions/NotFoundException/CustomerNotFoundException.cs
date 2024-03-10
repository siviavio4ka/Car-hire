namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class CustomerNotFoundException : NotFoundException
{
    public CustomerNotFoundException(int customerId) 
        : base($"The customer with id: {customerId} doesn't exist in the database.")
    {
    }
}