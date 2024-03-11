using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.CarDTO;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Services;

internal sealed class CarService : ICarService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CarService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repository = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CarDto>> GetAllCarsAsync(bool trackChanges)
    {
        var cars = await _repository.Car.GetAllCarsAsync(trackChanges);
        var carsDto = _mapper.Map<IEnumerable<CarDto>>(cars);
        return carsDto;
    }

    public async Task<CarDto> GetCarAsync(int carId, bool trackChanges)
    {
        var car = await _repository.Car.GetCarAsync(carId, trackChanges)
            ?? throw new CarNotFoundException(carId);

        var carDto = _mapper.Map<CarDto>(car);
        return carDto;
    }

    public async Task<IEnumerable<CarWithHoursDto>> GetCarsWithAmountHoursAsync(bool trackChanges)
    {
        var carsWithHours = await _repository.Car.GetCarsWithAmountHoursAsync(trackChanges);
        var carsWithHoursDto = carsWithHours
            .Select(cwh => new CarWithHoursDto
            {
                Car = _mapper.Map<CarDto>(cwh.car),
                QuantityHours = cwh.quantityHours
            })
        .ToList();
        return carsWithHoursDto;
    }

    public async Task<IEnumerable<CarDto>> GetMostPopularCarsAsync(bool trackChanges)
    {
        var cars = await _repository.Car.GetMostPopularCarsAsync(trackChanges);
        var carsDto = _mapper.Map<IEnumerable<CarDto>>(cars);
        return carsDto;
    }

    public async Task CreateCarAsync(CarForCreationDto car)
    {
        var carEntity = _mapper.Map<Car>(car);
        _repository.Car.CreateCar(carEntity);
        await _repository.SaveAsync();
    }

    public async Task UpdateCarAsync(int carId, CarForUpdateDto car, bool trackChanges)
    {
        var carEntity = await _repository.Car.GetCarAsync(carId, trackChanges)
            ?? throw new CarNotFoundException(carId);

        _mapper.Map(car, carEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteCarAsync(int carId, bool trackChanges)
    {
        var car = await _repository.Car.GetCarAsync(carId, trackChanges)
            ?? throw new CarNotFoundException(carId);

        _repository.Car.DeleteCar(car);
        await _repository.SaveAsync();
    }
}