using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Oxit.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();
builder.Services.AddAppDependencies();
builder.Services.AddRateLimiting();
builder.Services.AddTurkishLocalization();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//var locale = "tr-TR";
//RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions
//{
//    SupportedCultures = new List<CultureInfo> { new CultureInfo(locale) },
//    SupportedUICultures = new List<CultureInfo> { new CultureInfo(locale) },
//    DefaultRequestCulture = new RequestCulture(locale)
//};
//app.UseRequestLocalization(localizationOptions);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
