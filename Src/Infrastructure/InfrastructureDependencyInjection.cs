using Application.Common.Utilities;
using Application.Interfaces.Infrastructure;
using Infrastructure.Services.MongoDB;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Conventions;

namespace Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddMongoDataBase(this IServiceCollection services, string mongoConnectionString, string dataBaseName, AppSettings appSettings)
        {
            var convencionCamelCase = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", convencionCamelCase, t => true);

            services.AddScoped<IEventsRepository, EventsAdapter>();
            services.AddSingleton<IContext>(provider => Context.GetMongoDatabase(mongoConnectionString, dataBaseName, appSettings));
            return services;
        }
    }
}