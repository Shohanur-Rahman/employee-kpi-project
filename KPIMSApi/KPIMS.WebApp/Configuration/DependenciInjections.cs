using KPIMS.WebApp.Utilities;

namespace KPIMS.WebApp.Configuration
{
    public static class DependenciInjections
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddScoped<AuthGuirdService>();
            services.AddScoped<HelperService>();
            return services;
        }
    }
}
