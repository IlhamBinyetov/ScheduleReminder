using ScheduleReminder.Models;

namespace ScheduleReminder.Services
{
    public interface IReminderRepository
    {
        Task<Reminder> CreateReminder(Reminder reminder);
        Task<IEnumerable<Reminder>> GetReminders();
        Task<Reminder> GetReminder(int id);
        Task UpdateReminder(Reminder reminder);
        Task DeleteReminders(int[] ids);
    }
}
