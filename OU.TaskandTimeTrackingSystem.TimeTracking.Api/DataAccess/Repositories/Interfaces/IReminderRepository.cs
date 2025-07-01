using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces
{
    public interface IReminderRepository
    {
        Task AddReminderAsync(Reminder reminder, CancellationToken cancellationToken);
        Task UpdateReminderAsync(Reminder reminder, CancellationToken cancellationToken);
        Task DeleteReminderAsync(Reminder reminder, CancellationToken cancellationToken);
        Task<Reminder> GetReminderByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Reminder>> GetAllRemindersAsync(CancellationToken cancellationToken);
    }
}
