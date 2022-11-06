using OtusDocker.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () => new HealthResponse { Status = "OK" });

app.Run();
