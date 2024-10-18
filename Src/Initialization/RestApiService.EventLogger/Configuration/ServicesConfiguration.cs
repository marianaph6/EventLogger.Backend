using Application;

namespace RestApiService.EventLogger.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUseCases();
            return services;
        }
    }
}