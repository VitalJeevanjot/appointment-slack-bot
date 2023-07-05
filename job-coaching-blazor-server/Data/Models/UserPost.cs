using System.ComponentModel.DataAnnotations;

namespace job_coaching_blazor_server.Data.Models
{
    public class UserPost
    {
        [Key]
        public int Id { get; set; }
        public string? PostId { get; set; }
        public string? UrlId { get; set; }
        public string? JobTitle { get; set; }
        public string? YearsOfExperience { get; set; }
        public string? SizeOfCompany { get; set; }
        public string? OtherDetails { get; set; }
        public string? RequiredHelp { get; set; }
        public string? CreatorEmail { get; set; }
        public DateTime PostCreated { get; set; }
    }
}
