namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class EmployeeNotFoundException : NotFoundException
{
    public EmployeeNotFoundException(int employeeId) 
        : base($"The employee with id: {employeeId} doesn't exist in the database.")
    {
    }
}