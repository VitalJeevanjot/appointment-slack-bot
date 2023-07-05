using job_coaching_blazor_server.Data;
using job_coaching_blazor_server.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace job_coaching_blazor_server.Services
{
    public class UserPostService
    {
        private IDbContextFactory<MyDbContext> _dbContextFactory;

        public UserPostService(IDbContextFactory<MyDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddUserPost(UserPost userPost)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.UsersPosts.Add(userPost);
                context.SaveChanges();
            } 
        }
        public List<UserPost> GetUserAllPosts(string email)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                var user_posts = context.UsersPosts.Where(post => post.CreatorEmail == email).ToList();
                return user_posts;
            }
        }
        public UserPost GetUserPost(string UrlID)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user_post = context.UsersPosts.SingleOrDefault(x => x.UrlId == UrlID);
                return user_post;
            }
        }
        public void RemoveUserPost(string UrlID)
        {
            var userPost = GetUserPost(UrlID);

            if (userPost == null)
            {
                throw new Exception("UserPost doesn't exist");
            }
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.UsersPosts.Remove(userPost);
                context.SaveChanges();
            }
        }
        public void AddAppointment(Appointment appointment)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
            }
        }

        public List<Appointment> GetAppointments(string UrlID)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var appointments = context.Appointments.Where(app => app.UrlId == UrlID).ToList();
                return appointments;
            }
        }

        // TODO: Edit Appointment, Delete Appointment, Send Email on Appointment, Google calender addition on appointment, Add appointment link for each post on sidebar.
    }
}
