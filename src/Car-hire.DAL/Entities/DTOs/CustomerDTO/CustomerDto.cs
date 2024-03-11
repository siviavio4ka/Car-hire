namespace Car_hire.DAL.Entities.DTOs.CustomerDTO;

public record CustomerDto(int CustomerId, string Name, string PassportDetails, string Address, string PhoneNumber, int DriverLicenceNumber);