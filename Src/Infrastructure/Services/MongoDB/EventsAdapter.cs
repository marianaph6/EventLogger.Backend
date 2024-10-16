using Application.DTOs.Event;
using Application.Interfaces.Infrastructure;
using Core.Entities;
using MongoDB.Driver;

namespace Infrastructure.Services.MongoDB
{
    public class EventsAdapter : IEventsRepository
    {
        private readonly IContext _context;

        public EventsAdapter(IContext context)
        {
            _context = context;
        }

        public async Task<EventLog> InsertEvent(EventLog eventLog)
        {
            await _context.EventLog.InsertOneAsync(eventLog);
            return eventLog;
        }

        public async Task<List<EventLog>> FindAllEvents(EventFilterInput eventFilterInput)
        {
            var filterDefinition = Builders<EventLog>.Filter.Empty;
            if (!string.IsNullOrEmpty(eventFilterInput.EventType))
            {
                filterDefinition &= Builders<EventLog>.Filter.Eq(e => e.EventType, eventFilterInput.EventType);
            }
            if (eventFilterInput.StartDate.HasValue && eventFilterInput.EndDate.HasValue)
            {
                filterDefinition &= Builders<EventLog>.Filter.Gte(e => e.Timestamp, eventFilterInput.StartDate) &
                                    Builders<EventLog>.Filter.Lte(e => e.Timestamp, eventFilterInput.EndDate);
            }
            return await _context.EventLog.Find(filterDefinition).ToListAsync();
        }
    }
}