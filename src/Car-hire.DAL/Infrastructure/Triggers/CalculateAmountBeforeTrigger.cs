using Car_hire.DAL.Entities.Models;
using EntityFrameworkCore.Triggered;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class CalculateAmountBeforeTrigger : IBeforeSaveAsyncTrigger<Order>
{
    public Task BeforeSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        if (context.ChangeType == ChangeType.Added || context.ChangeType == ChangeType.Modified)
        {
            context.Entity.Amount = context.Entity.Car.HirePrice * context.Entity.HireHours;
        }

        return Task.CompletedTask;
    }
}