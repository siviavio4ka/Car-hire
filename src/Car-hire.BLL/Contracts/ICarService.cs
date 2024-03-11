using Car_hire.DAL.Entities.DTOs.CarDTO;

namespace Car_hire.BLL.Contracts;

public interface ICarService
{
    Task<IEnumerable<CarDto>> GetAllCarsAsync(bool trackChanges);
    Task<CarDto> GetCarAsync(int carId, bool trackChanges);
    Task<IEnumerable<CarDto>> GetMostPopularCarsAsync(bool trackChanges);
    Task<IEnumerable<CarWithHoursDto>> GetCarsWithAmountHoursAsync(bool trackChanges);
    Task CreateCarAsync(CarForCreationDto car);
    Task UpdateCarAsync(int carId,CarForUpdateDto car, bool trackChanges);
    Task DeleteCarAsync(int carId, bool trackChanges);
}