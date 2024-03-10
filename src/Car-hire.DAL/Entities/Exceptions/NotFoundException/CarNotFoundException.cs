namespace Car_hire.DAL.Entities.Exceptions.NotFoundException;

public class CarNotFoundException : NotFoundException
{
    public CarNotFoundException(int carId)
        : base($"The car with id: {carId} doesn't exist in the database.")
    {
    }
}