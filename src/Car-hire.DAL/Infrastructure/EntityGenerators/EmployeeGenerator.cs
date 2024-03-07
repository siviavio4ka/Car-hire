using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Infrastructure.EntityGenerators;

public static class EmployeeGenerator
{
    private static readonly Random Random = new();

    private static readonly List<string> FirstNames = new()
    {
        "John", "Jane", "Alice", "Bob", "Emily", "Michael", "David", "Sarah", "Jessica",
        "William", "James", "Mary", "Robert", "Linda", "Christopher", "Patricia", "Daniel",
        "Barbara", "Matthew", "Elizabeth", "Joseph", "Jennifer", "Charles", "Maria", "Thomas",
        "Susan", "Jessica", "Andrew", "Margaret", "Anthony"
    };

    private static readonly List<string> LastNames = new()
    {
        "Smith", "Johnson", "Brown", "Williams", "Davis", "Miller", "Wilson", "Moore", "Taylor",
        "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia",
        "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall",
        "Allen", "Young", "Hernandez", "King", "Wright"
    };

    public static IEnumerable<Employee> GenerateEmployee(int count) =>
        Enumerable.Range(1, count).Select(i => new Employee 
        {
            EmployeeId = i,
            Name = GenerateName()
        });

    private static string GenerateName() =>
        $"{FirstNames[Random.Next(FirstNames.Count)]}, {LastNames[Random.Next(LastNames.Count)]}";
}