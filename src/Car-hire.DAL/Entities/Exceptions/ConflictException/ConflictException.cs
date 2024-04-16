namespace Car_hire.DAL.Entities.Exceptions.ConflictException;

public abstract class ConflictException : Exception
{
    protected ConflictException(string message) : base(message)
    {
    }
}