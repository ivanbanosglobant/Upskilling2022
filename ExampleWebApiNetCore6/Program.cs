using ExampleWebApiNetCore6.Application;
using ExampleWebApiNetCore6.DataBase;
using ExampleWebApiNetCore6.DataBase.DbInterface;
using ExampleWebApiNetCore6.Filters;
using MediatR;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(op => op.Filters.Add(new ParkingExceptionFilter()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(IApplicationAnchor));
builder.Services.AddScoped<IDataBaseHandler, SqlServerDataBaseHandler>();
builder.Services.AddSingleton<IConfigureOptions<Database>, DatabaseConfiguration>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
