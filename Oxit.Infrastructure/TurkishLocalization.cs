using AspNetCoreRateLimit;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Oxit.Common.Automapper;
using Oxit.Common.DataAccess.EntityFramework;
using Oxit.Common.Domain;
using Oxit.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Infrastructure
{
    public static class TurkishLocalization
    {
        public static IServiceCollection AddTurkishLocalization(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[] { new CultureInfo("tr") };
                options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
                {
                    return new ProviderCultureResult("tr-TR");
                }));
            });
            return services;
        }
    }
}
