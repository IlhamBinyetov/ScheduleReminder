using Microsoft.EntityFrameworkCore;
using ScheduleReminder.Models;

namespace ScheduleReminder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Reminder> Reminders { get; set; }
    }
}
