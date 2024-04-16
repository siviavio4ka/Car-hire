namespace Car_hire.DAL.Entities.Exceptions.BadRequestException;

public class InvalidPasswordBadRequestException : BadRequestException
{
    public InvalidPasswordBadRequestException() 
        : base("Invalid email or password")
    {
    }
}