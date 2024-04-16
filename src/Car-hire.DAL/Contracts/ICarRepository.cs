using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Contracts;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetAllCarsAsync(bool trackChanges);
    Task<Car> GetCarAsync(int carId, bool trackChanges);
    Task<IEnumerable<Car>> GetMostPopularCarsAsync(bool trackChanges);
    Task<IEnumerable<(Car car, int quantityHours)>> GetCarsWithAmountHoursAsync(bool trackChanges);
    void CreateCar(Car car);
    void DeleteCar(Car car);
}