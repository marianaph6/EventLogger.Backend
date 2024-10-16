using Application.DTOs.Event;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace RestApiService.EventLogger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        //Inyectar los services

        private readonly ILogger<EventsController> _logger;
        private readonly IEventUseCase _eventUseCase;

        public EventsController(ILogger<EventsController> logger, IEventUseCase eventUseCase)
        {
            _logger = logger;
            _eventUseCase = eventUseCase;
        }

        [HttpPost("create-event")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventInput body)
        {
            return Ok(await _eventUseCase.CreateEvent(body));
        }

        [HttpGet("get-events")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetEvents([FromQuery] EventFilterInput query)
        {
            return Ok(await _eventUseCase.GetEvent(query));
        }
    }
}