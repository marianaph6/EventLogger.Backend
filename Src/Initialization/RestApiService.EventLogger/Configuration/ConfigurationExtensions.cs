namespace RestApiService.EventLogger.Configuration
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder AddJsonProvider(this IConfigurationBuilder configuration, IWebHostEnvironment environment)
            => configuration
                .AddJsonFile("config/appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment.ApplicationName}.json", optional: true, reloadOnChange: true);
    }
}