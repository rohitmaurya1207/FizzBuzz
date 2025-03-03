using FizzBuzzProcessor.API.FizzBuzzProcessor.Core.Services;
using Microsoft.Win32;

var builder = WebApplication.CreateBuilder(args);

// Register FizzBuzzService using Dependency Injection
builder.Services.AddScoped<IFizzBuzzService, FizzBuzzService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
