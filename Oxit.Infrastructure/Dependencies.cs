using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Oxit.Common.Automapper;
using Oxit.Common.DataAccess.EntityFramework;
using Oxit.Common.Domain;
using Oxit.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection AddAppDependencies(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddOptions();
            services.AddMemoryCache();
            services.AddSingleton(CommonMappingProfiles.GetProfiles().CreateMapper());
            services.AddScoped<Random>();
            services.AddDbContext<appDbContext>();
            services.AddDbContext<CommonDbContext>();
            services.AddCommonServices();
            services.AddCors(x =>
            {
                //angular icin farkli sunucudan sorgu atmamizi saglar
                x.AddPolicy("Cors", p =>
                {
                    p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });

            });
            return services;
        }
    }
}
