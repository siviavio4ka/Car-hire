namespace Car_hire.DAL.Entities.DTOs.OrderDTO;

public record OrderDto(int OrderId, int OrderNumber, int CarId, DateTime OrderDate, int UserId, 
    int HireHours, DateTime Deadline, double Amount);