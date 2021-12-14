using Oxit.DataAccess.EntityFramework;
using Oxit.Infrastructure;
using Oxit.Scheduling.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<appDbContext>();
builder.Services.AddMemoryCache();

#region dependency
builder.Services.AddAppDependencies();
#endregion
builder.Services.AddScheduledJobs();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
