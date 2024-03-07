using Car_hire.DAL.Entities.Models;
using Car_hire.DAL.Entities.Enums;
using EntityFrameworkCore.Triggered;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class UpdateCarStatusAfterTrigger : IAfterSaveAsyncTrigger<Order>
{
    public Task AfterSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        if (context.Entity.Deadline == DateTime.Now)
            context.Entity.Car.Status = Status.Available;

        return Task.CompletedTask;
    }
}