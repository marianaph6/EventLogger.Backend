using Application.Interfaces.Services;
using Application.Services.Simple;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IEventUseCase, EventService>();
            return services;
        }
    }
}