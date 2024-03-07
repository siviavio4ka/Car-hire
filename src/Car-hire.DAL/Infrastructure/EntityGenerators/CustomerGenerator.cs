using Car_hire.DAL.Entities.Models;

namespace Car_hire.DAL.Infrastructure.EntityGenerators;

public static class CustomerGenerator
{
    private static readonly Random Random = new();

    private static readonly List<string> Streets = new()
    {
        "Main Street", "Elm Street", "Oak Street", "Pine Street", "Cedar Street",
        "Maple Street", "Washington Avenue", "Park Avenue", "Church Street", "Lakeview Drive",
        "Sunset Boulevard", "High Street", "Broadway", "Victory Street", "School Lane",
        "Green Avenue", "River Road", "Hillside Avenue", "Central Avenue", "First Street",
        "Second Street", "Third Street", "Fourth Street", "Fifth Street", "Sixth Street",
        "Seventh Street", "Eighth Street", "Ninth Street", "Tenth Street", "Baker Street"
    };

    private static readonly List<string> Cities = new()
    {
        "Cityville", "Townville", "Villageton", "Hamletville", "Suburbia",
        "Metropolis", "Villageville", "Township", "Countyville", "Smalltown",
        "Harbor City", "Bayview", "Springfield", "Riverside", "Hillcrest",
        "Oakwood", "Maplewood", "Pinecrest", "Fairview", "Westminster",
        "Lexington", "Evergreen", "Lakeview", "Crestview", "Cedarville",
        "Valleyview", "Mountainview", "Northfield", "Southfield", "Eastwood"
    };

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

    private static readonly List<string> TelephoneNumberCodes = new()
    {
        "44", "29", "33", "232", "25"
    };

    public static IEnumerable<Customer> GenerateCustomer(int count, int minValue, int maxValue, int numberOfStreet) =>
        Enumerable.Range(1, count).Select(i => new Customer
        {
            CustomerId = i,
            Name = GenerateName(),
            PassportDetails = GeneratePassportDetails(minValue, maxValue),
            Address = GenerateAddress(numberOfStreet),
            PhoneNumber = GeneratedPhoneNumber(),
            DriverLicenceNumber = Random.Next(100000000, 999999999)
        });

    private static string GenerateName() =>
        $"{FirstNames[Random.Next(FirstNames.Count)]}, {LastNames[Random.Next(LastNames.Count)]}";

    private static string GenerateAddress(int numberOfStreet) =>
        $"{Random.Next(1, numberOfStreet)} {Streets[Random.Next(Streets.Count)]}, {Cities[Random.Next(Cities.Count)]}";

    private static string GeneratePassportDetails(int minValue, int maxValue) =>
        (char)('A' + Random.Next(26)) + "" + (char)('A' + Random.Next(26)) + Random.Next(minValue, maxValue);
    
    private static string GeneratedPhoneNumber() =>
        $"+375 {TelephoneNumberCodes[Random.Next(TelephoneNumberCodes.Count)]} {Random.Next(1000000, 9999999)}";
}