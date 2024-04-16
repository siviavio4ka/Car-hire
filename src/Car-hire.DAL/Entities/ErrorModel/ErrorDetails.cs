using System.Text.Json;

namespace Car_hire.DAL.Entities.ErrorModel;

public class ErrorDetails
{
    public int StatusCode { get; set; }
    public string? Message { get; set; }

    public override string ToString() => JsonSerializer.Serialize(this);
}