using Car_hire.DAL.Entities.Models;
using EntityFrameworkCore.Triggered;

namespace Car_hire.DAL.Infrastructure.Triggers;

public class CalculateAmountBeforeTrigger : IBeforeSaveAsyncTrigger<Order>
{
    private readonly ApplicationContext _applicationContext;

    public CalculateAmountBeforeTrigger(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public Task BeforeSaveAsync(ITriggerContext<Order> context, CancellationToken cancellationToken)
    {
        if (context.ChangeType == ChangeType.Added || context.ChangeType == ChangeType.Modified)
        {
            context.Entity.Amount = context.Entity.HireHours * 
            _applicationContext.Cars.Where(c => c.CarId == context.Entity.CarId).FirstOrDefault()!.HirePrice;
        }

        return Task.CompletedTask;
    }
}