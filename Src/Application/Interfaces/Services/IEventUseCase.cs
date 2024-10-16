using Application.DTOs.Event;
using Core.Entities;

namespace Application.Interfaces.Services
{
    public interface IEventUseCase
    {
        public Task<EventLog> CreateEvent(CreateEventInput createEventInput);
        public Task<List<EventLog>> GetEvent(EventFilterInput eventFilterInput);
    }
}
