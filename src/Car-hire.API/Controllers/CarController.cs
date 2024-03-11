using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.CarDTO;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/cars")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IServiceManager _service;

    public CarController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCars()
    {
        var cars = await _service.CarService.GetAllCarsAsync(false);
        return Ok(cars);
    }

    [HttpGet("{carId:int}")]
    public async Task<IActionResult> GetCar(int carId)
    {
        var car = await _service.CarService.GetCarAsync(carId, false);
        return Ok(car);
    }

    [HttpGet("most-popular")]
    public async Task<IActionResult> GetMostPopularCars()
    {
        var cars = await _service.CarService.GetMostPopularCarsAsync(false);
        return Ok(cars);
    }

    [HttpGet("all-hours")]
    public async Task<IActionResult> GetCarsWithAmountHours()
    {
        var carsWithHours = await _service.CarService.GetCarsWithAmountHoursAsync(false);
        return Ok(carsWithHours);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCar([FromBody] CarForCreationDto? car)
    {
        if (car is null)
            return BadRequest("CarForCreationDto object is null");
        
        await _service.CarService.CreateCarAsync(car);
        return Ok();
    }

    [HttpPut("{carId:int}")]
    public async Task<IActionResult> UpdateCar(int carId, [FromBody] CarForUpdateDto? car)
    {
        if (car is null)
            return BadRequest("CarForUpdateDto object is null");

        await _service.CarService.UpdateCarAsync(carId, car, true);
        return NoContent();
    }

    [HttpDelete("{carId:int}")]
    public async Task<IActionResult> DeleteCar(int carId)
    {
        await _service.CarService.DeleteCarAsync(carId, false);
        return NoContent();
    }
}