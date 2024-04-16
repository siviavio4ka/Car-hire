namespace Car_hire.DAL.Entities.Exceptions.BadRequestException;

public class RegistrationBadRequestException : BadRequestException
{
    public RegistrationBadRequestException() 
        : base("Failed to register a user")
    {
    }
}