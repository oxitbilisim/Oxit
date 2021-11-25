using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Oxit.Common.Exception;
using Oxit.Core.Utilities;
using Oxit.DataAccess.EntityFramework;
using Oxit.Infrastructure;
using System.Globalization;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAppDependencies();
builder.Services.AddRateLimiting();
builder.Services.AddTurkishLocalization();

var app = builder.Build();
app.UseClientRateLimiting();


var cultureInfo = new CultureInfo("tr-TR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";
            var error = context.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
                await context.Response.WriteAsync(new GenericExeption("Sistemde beklenmedik bir hata oluştu").ToJson(), Encoding.UTF8);
        });
    });

}

app.UseAuthorization();
app.MapControllers();
app.Run();
