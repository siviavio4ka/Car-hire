namespace Car_hire.DAL.Entities.DTOs.UserDTO.Auth;

public record UserDto(int Id, string Name, string UserName, string Email, 
    string PassportDetails, string Address, string PhoneNumber);