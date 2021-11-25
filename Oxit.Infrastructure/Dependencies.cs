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
            services.AddSingleton(CommonMappingProfiles.GetProfiles().CreateMapper());
            services.AddScoped<Random>();
            services.AddDbContext<appDbContext>();
            services.AddDbContext<CommonDbContext>();
            services.AddCommonServices();
            return services;
        }
    }
}
