using Application.DTOs.Event;
using Core.Entities;

namespace Application.Interfaces.Infrastructure
{
    public interface IEventsRepository
    {
        Task<EventLog> InsertEvent(EventLog eventLog);

        Task<List<EventLog>> FindAllEvents(EventFilterInput eventFilterInput);
    }
}