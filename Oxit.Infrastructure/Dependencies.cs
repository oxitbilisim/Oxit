using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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
                    p.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });

            });
            services.Configure<FormOptions>(c =>
            {

                c.ValueLengthLimit = int.MaxValue;
                c.MultipartBodyLengthLimit = int.MaxValue;
                c.MemoryBufferThreshold = int.MaxValue;
            });
            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddRoles<IdentityRole>()
               .AddUserManager<UserManager<IdentityUser>>()
               .AddRoleManager<RoleManager<IdentityRole>>()
               .AddEntityFrameworkStores<appDbContext>()
               .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
            });
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Settings.JWT.Secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            }); ;
            services.AddAuthorization();
            return services;
        }
    }
}
