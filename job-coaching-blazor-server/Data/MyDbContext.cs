using job_coaching_blazor_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace job_coaching_blazor_server.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : 
            base(options) 
        {

        }
        public DbSet<UserPost> UsersPosts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
