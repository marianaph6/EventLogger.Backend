
using Microsoft.Extensions.Logging;

namespace Application.Common.Helpers
{
    public class ManageEventsUseCase : IManageEventsUseCase
    {
        private readonly ILogger<ManageEventsUseCase> _logger;

        public async Task ConsoleLogAsync(string eventName, string id, dynamic data, bool writeData = false) =>
            await Task.Run(() =>
            {
                _logger.LogInformation($"EventName: {eventName} - Id: {id}");
                if (writeData)
                {
                    _logger.LogInformation($"Data: {data}");
                }
            });

        public void ConsoleErrorLog(string message, Exception exception)
        {
            _logger.LogError("ERROR - {message} :: {@exception}", message, exception);
        }

        public void ConsoleTraceLog(string message)
        {
            _logger.LogTrace("TRACE - {message}", message);
        }
    }
}
