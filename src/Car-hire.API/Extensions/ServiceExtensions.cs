using Car_hire.DAL;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Infrastructure.Triggers;
using Car_hire.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureDbContext(this IServiceCollection services) =>
        services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseTriggers(triggerOptions =>
            {
                triggerOptions.AddTrigger<UpdateCarStatusBeforeTrigger>(ServiceLifetime.Transient);
                triggerOptions.AddTrigger<UpdateCarStatusAfterTrigger>(ServiceLifetime.Transient);
                triggerOptions.AddTrigger<CalculateAmountBeforeTrigger>(ServiceLifetime.Transient);
                triggerOptions.AddTrigger<CalculateDeadlineBeforeTrigger>(ServiceLifetime.Transient);
            });
        });
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureLoggerManager(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
}