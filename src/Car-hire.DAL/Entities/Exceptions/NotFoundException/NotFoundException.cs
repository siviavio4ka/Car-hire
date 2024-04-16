namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message) : base(message)
    {
    }
}