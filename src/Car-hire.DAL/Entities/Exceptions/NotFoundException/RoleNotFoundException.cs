namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class RoleNotFoundException : NotFoundException
{
    public RoleNotFoundException() 
        : base("The role doesn't exist in the database.")
    {
    }

    public RoleNotFoundException(int roleId)
        : base($"The role with id: {roleId} doesn't exist in the database.")
    {
    }
}