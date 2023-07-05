namespace job_coaching_blazor_server.Data.Shared
{
    public class Appointment
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string Text { get; set; }
        public string? UUID { get; set; }
        public string? Creator { get; set; }
    }

}
