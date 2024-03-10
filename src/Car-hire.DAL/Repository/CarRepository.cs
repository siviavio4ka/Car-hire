using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public class CarRepository : RepositoryBase<Car>, ICarRepository
{
    public CarRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public async Task<IEnumerable<Car>> GetAllCarsAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c => c.Brand)
            .ToListAsync();

    public async Task<Car> GetCarAsync(int carId, bool trackChanges) =>
        await FindByCondition(c => c.CarId.Equals(carId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<Car>> GetMostPopularCarsAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderByDescending(c => c.Orders.Count)
            .Take(10)
            .ToListAsync();

    public async Task<IEnumerable<(Car car, int quantityHours)>> GetCarsWithAmountHoursAsync(bool trackChanges)
    {
        var carsWithHours = await FindAll(trackChanges)
            .Select(c => new
            {
                Car = c,
                QuantityHours = c.Orders.Sum(order => order.HireHours)
            })
            .ToListAsync();

        return carsWithHours.Select(result => (result.Car, result.QuantityHours));
    }

    public void CreateCar(Car car) => Create(car);

    public void DeleteCar(Car car) => Delete(car);
}