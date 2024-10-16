namespace Application.DTOs.Event
{
    public class EventFilterInput
    {
        public string EventType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}