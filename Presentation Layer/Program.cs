using Microsoft.EntityFrameworkCore;
using NTierExample.Data.Context;
using NTierExample.Data.Startup;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryContext>(options => {
    options.UseMySQL(connectionString); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // app.InitializeDB();
}

// For now, just call the Data Layer startup to seed DB

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
