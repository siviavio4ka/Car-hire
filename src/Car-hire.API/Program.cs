using Car_hire.DAL;
using Car_hire.DAL.Infrastructure.Triggers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseTriggers(triggerOptions =>
    {
        triggerOptions.AddTrigger<UpdateCarStatusBeforeTrigger>(ServiceLifetime.Transient);
        triggerOptions.AddTrigger<UpdateCarStatusAfterTrigger>(ServiceLifetime.Transient);
        triggerOptions.AddTrigger<CalculateAmountBeforeTrigger>(ServiceLifetime.Transient);
        triggerOptions.AddTrigger<CalculateDeadlineBeforeTrigger>(ServiceLifetime.Transient);
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
