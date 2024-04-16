using Car_hire.DAL.Entities.Enums;

namespace Car_hire.DAL.Entities.DTOs.CarDTO;

public record CarDto(int CarId, string Number, Brand Brand, int Mileage, Status Status, int SeatingCapacity, double HirePrice);