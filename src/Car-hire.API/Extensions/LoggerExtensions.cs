using Serilog;

namespace Car_hire.API.Extensions;

public static class LoggerExtensions
{
    public static void ConfigureSerilog(this ILoggingBuilder builder)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
                .AddJsonFile("serilog.config.json")
                .Build())
            .Enrich.FromLogContext()
            .CreateLogger();

        builder.ClearProviders();
        builder.AddSerilog(logger);
    }
}