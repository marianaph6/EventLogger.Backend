namespace Core.Entities
{
    public class EventLog
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string EventType { get; set; } // "Api" o "Formulario"
        public DateTime Timestamp { get; set; }
    }

}
