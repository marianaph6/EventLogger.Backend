using Application.DTOs.Event;
using Application.Interfaces.Services;
using Core.Entities;

namespace Application.Services.Simple
{
    public class EventService : IEventUseCase
    {
        public Task<EventLog> CreateEvent(CreateEventInput createEventInput)
        {
            EventLog eventLog = new()
            {
                Id = Guid.NewGuid(),
                Description = createEventInput.Description,
                EventType = createEventInput.EventType,
                Timestamp = DateTime.Now
            };
            return Task.FromResult(eventLog);
        }

        public Task<List<EventLog>> GetEvent(EventFilterInput eventFilterInput)
        {
            List<EventLog> listEventLog = new()
            {
                new EventLog
                {
                    Id = Guid.NewGuid(),
                    Description = "Demo2",
                    EventType = "Demo2",
                    Timestamp = DateTime.Now
                }
            };
            return Task.FromResult(listEventLog);
        }
    }
}
