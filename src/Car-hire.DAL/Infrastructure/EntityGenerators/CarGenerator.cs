using Car_hire.DAL.Entities.Enums;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Infrastructure.EntityGenerators;

public static class CarGenerator
{
    private static readonly Random Random = new();

    public static IEnumerable<Car> GenerateCar(int count, int maxMileage, int maxSeatingCapacity, int minPrice, int maxPrice) =>
        Enumerable.Range(1, count).Select(i => new Car
        {
            CarId = i,
            Number = GenerateCarNumber(),
            Brand = (Brand)Random.Next(Enum.GetNames(typeof(Brand)).Length),
            Mileage = Random.Next(1, maxMileage),
            Status = (Status)Random.Next(Enum.GetNames(typeof(Status)).Length),
            SeatingCapacity = Random.Next(2, maxSeatingCapacity),
            HirePrice = Random.Next(minPrice, maxPrice)
        });

    private static string GenerateCarNumber() =>
        Random.Next(1000, 9999) + " " + (char)('A' + Random.Next(26)) + (char)('A' + Random.Next(26)) + "-" + Random.Next(1, 7);
}