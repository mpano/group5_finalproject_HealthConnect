namespace HealthConnectAPI.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = new DateTime();
        
    }
}
