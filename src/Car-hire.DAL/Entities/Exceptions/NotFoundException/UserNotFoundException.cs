namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(int userId) 
        : base($"The user with id: {userId} doesn't exist in the database.")
    {
    }

    public UserNotFoundException(string email)
        : base($"The user with email: {email} doesn't exist in the database.")
    {
    }
}