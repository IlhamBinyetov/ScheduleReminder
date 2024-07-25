using Microsoft.EntityFrameworkCore;
using ScheduleReminder.Data;
using ScheduleReminder.Models;

namespace ScheduleReminder.Services
{
    public class ReminderService : IReminderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ReminderService(ApplicationDbContext dbContext)
        {
                _dbContext = dbContext;
        }
        public async Task<Reminder> CreateReminder(Reminder reminder)
        {
            _dbContext.Reminders.Add(reminder);
            await _dbContext.SaveChangesAsync();
            return reminder;
        }

        public Task DeleteReminders(int[] ids)
        {
            throw new NotImplementedException();
        }

        public async Task<Reminder> GetReminder(int id)
        {
            return await _dbContext.Reminders.FindAsync(id);
        }

        public Task<IEnumerable<Reminder>> GetReminders()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateReminder(Reminder reminder)
        {
            _dbContext.Entry(reminder).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }




}
