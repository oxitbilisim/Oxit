using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;

namespace Oxit.Infrastructure
{
    public static class RateLimiting
    {
        public static IServiceCollection AddRateLimiting(this IServiceCollection services)
        {
            services.AddInMemoryRateLimiting();
            services.Configure<ClientRateLimitOptions>(options =>
            {
                options.GeneralRules = new List<RateLimitRule>
    {
        new RateLimitRule
        {
            Endpoint = "*",
            Period = "1s",
            Limit = 3,
        }
    };
            });
            services.Configure<IpRateLimitOptions>(options =>
            {
                options.GeneralRules = new List<RateLimitRule>
    {
        new RateLimitRule
        {
            Endpoint = "*",
            Period = "1s",
            Limit = 3,
        }
    };
            });
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();

            return services;
        }
    }
}
