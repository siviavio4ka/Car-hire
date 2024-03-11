using Car_hire.BLL.Contracts;
using Car_hire.BLL.Services;
using Car_hire.DAL;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Repository;

namespace Car_hire.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureDbContext(this IServiceCollection services) =>
        services.AddDbContext<ApplicationContext>();
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureLoggerManager(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();
}