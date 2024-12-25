using EventReminder.Models;
using Microsoft.EntityFrameworkCore;

namespace EventReminder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; } // Define your DbSet
    }
}
