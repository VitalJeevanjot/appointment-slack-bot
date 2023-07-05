using System.ComponentModel.DataAnnotations;

namespace job_coaching_blazor_server.Data.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public string? UrlId { get; set; }

        public string? Text { get; set; }
        public string? HelperEmail { get; set; }
        public DateTime AppointmentDurationEnd { get; set; }
        public DateTime AppointmentDateTime { get; set; }
    }
}
