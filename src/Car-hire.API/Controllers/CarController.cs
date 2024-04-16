using Car_hire.BLL.Contracts;
using Car_hire.DAL.Entities.DTOs.CarDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Car_hire.API.Controllers;

[Route("api/cars")]
[ApiController]
[Authorize]
public class CarController : ControllerBase
{
    private readonly IServiceManager _service;

    public CarController(IServiceManager service)
    {
        _service = service;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetAllCars()
    {
        var cars = await _service.CarService.GetAllCarsAsync(false);

        return Ok(cars);
    }

    [AllowAnonymous]
    [HttpGet("{carId:int}")]
    public async Task<IActionResult> GetCar(int carId)
    {
        var car = await _service.CarService.GetCarAsync(carId, false);

        return Ok(car);
    }

    [Authorize(Roles = "Admin, Employee")]
    [HttpGet("most-popular")]
    public async Task<IActionResult> GetMostPopularCars()
    {
        var cars = await _service.CarService.GetMostPopularCarsAsync(false);

        return Ok(cars);
    }

    [Authorize(Roles = "Admin, Employee")]
    [HttpGet("all-hours")]
    public async Task<IActionResult> GetCarsWithAmountHours()
    {
        var carsWithHours = await _service.CarService.GetCarsWithAmountHoursAsync(false);

        return Ok(carsWithHours);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<IActionResult> CreateCar([FromBody] CarForCreationDto? car)
    {
        if (car is null)
            return BadRequest("CarForCreationDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);
        
        await _service.CarService.CreateCarAsync(car);

        return Ok();
    }

    [Authorize(Roles = "Admin")]
    [HttpPut("{carId:int}")]
    public async Task<IActionResult> UpdateCar(int carId, [FromBody] CarForUpdateDto? car)
    {
        if (car is null)
            return BadRequest("CarForUpdateDto object is null");
        
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.CarService.UpdateCarAsync(carId, car, true);

        return NoContent();
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete("{carId:int}")]
    public async Task<IActionResult> DeleteCar(int carId)
    {
        await _service.CarService.DeleteCarAsync(carId, false);
        
        return NoContent();
    }
}