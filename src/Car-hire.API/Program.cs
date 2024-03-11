using Car_hire.API.Extensions;
using Car_hire.DAL.Contracts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureDbContext();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureLoggerManager();
builder.Logging.ConfigureSerilog();
builder.Services.ConfigureServiceManager();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

var loggerManager = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(loggerManager);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
