using Application.DTOs.Event;
using Application.Interfaces.Infrastructure;
using Application.Interfaces.Services;
using Core.Entities;

namespace Application.Services.Simple
{
    public class EventService : IEventUseCase
    {
        private readonly IEventsRepository _eventsRepository;

        public EventService(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        public async Task<EventLog> CreateEvent(CreateEventInput createEventInput)
        {
            EventLog eventLog = new()
            {
                Id = Guid.NewGuid(),
                Description = createEventInput.Description,
                EventType = createEventInput.EventType,
                Timestamp = DateTime.Now
            };

            var result = await _eventsRepository.InsertEvent(eventLog);

            return result;
        }

        public async Task<List<EventLog>> GetEvent(EventFilterInput eventFilterInput)
        {
            var result = await _eventsRepository.FindAllEvents(eventFilterInput);

            return result;
        }
    }
}