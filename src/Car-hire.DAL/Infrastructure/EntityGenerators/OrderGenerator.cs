using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Infrastructure.EntityGenerators;

public static class OrderGenerator
{
    private static readonly Random Random = new();

    public static IEnumerable<Order> GenerateOrder(int count, int maxCarId, DateTime startDay, int maxUserId, int maxHireHours) =>
        Enumerable.Range(1, count).Select(i => new Order
        {
            OrderId = i,
            OrderNumber = Random.Next(10000, 99999),
            CarId = Random.Next(1, maxCarId),
            OrderDate = GenerateDate(startDay),
            UserId = Random.Next(1, maxUserId),
            HireHours = Random.Next(1, maxHireHours)
        });

    private static DateTime GenerateDate(DateTime startDay)
    {
        var range = (DateTime.Today - startDay).Days;
        var hours = Random.Next(1, 24);
        var minutes = Random.Next(1, 60);
        return startDay.AddDays(Random.Next(range)).AddHours(hours).AddMinutes(minutes);
    }
}