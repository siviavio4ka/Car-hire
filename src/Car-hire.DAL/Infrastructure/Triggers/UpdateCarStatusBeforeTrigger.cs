using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Entities.Enums;
using EntityFrameworkCore.Triggered;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class UpdateCarStatusBeforeTrigger : IBeforeSaveAsyncTrigger<Order>
{
    public Task BeforeSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        if (context.ChangeType == ChangeType.Added && context.Entity.Car.Status != Status.Available)
            context.Entity.Car.Status = Status.Busy;
        else
            throw new Exception();
        
        return Task.CompletedTask;
    }
}