namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public record OrderDto(int OrderId, int OrderNumber, int CarId, DateTime OrderDate, int EmployeeId, int CustomerId, 
    int HireHours, DateTime Deadline, double Amount);