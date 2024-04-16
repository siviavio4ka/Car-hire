using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Entities.Enums;
using EntityFrameworkCore.Triggered;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class UpdateCarStatusTrigger : IBeforeSaveAsyncTrigger<Order>
{
    private readonly ApplicationContext _applicationContext;

    public UpdateCarStatusTrigger(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public Task BeforeSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        var car = _applicationContext.Cars.Where(c => c.CarId == context.Entity.CarId).FirstOrDefault();

        if (context.ChangeType == ChangeType.Added)
            car.Status = Status.Busy;

        return Task.CompletedTask;
    }
}