namespace Application.Common.Helpers
{
    public interface IManageEventsUseCase
    {
        Task ConsoleLogAsync(string eventName, string id, dynamic data, bool writeData = false);

        void ConsoleErrorLog(string message, Exception exception);

        void ConsoleTraceLog(string message);
    }
}
