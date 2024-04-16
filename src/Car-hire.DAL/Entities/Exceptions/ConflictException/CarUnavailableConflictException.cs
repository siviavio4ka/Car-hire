namespace Car_hire.DAL.Entities.Exceptions.ConflictException;

public class CarUnavailableConflictException : ConflictException
{
    public CarUnavailableConflictException() 
        : base("The car is unavailable for hire.")
    {
    }
}