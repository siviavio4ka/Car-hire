using Car_hire.DAL.Entities.Models;
using EntityFrameworkCore.Triggered;
using Serilog;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class CalculateDeadlineBeforeTrigger : IBeforeSaveAsyncTrigger<Order>
{
    public Task BeforeSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        if (context.ChangeType == ChangeType.Added || context.ChangeType == ChangeType.Modified)
        {
            context.Entity.Deadline = context.Entity.OrderDate.AddHours(context.Entity.HireHours);
        }

        return Task.CompletedTask;
    }
}