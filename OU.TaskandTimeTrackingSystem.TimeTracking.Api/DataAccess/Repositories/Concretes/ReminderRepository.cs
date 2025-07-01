using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Concretes
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly TimeTrackingContext _timeTrackingContext;
        private readonly DbSet<Reminder> _dbSet;

        public ReminderRepository(TimeTrackingContext timeTrackingContext)
        {
            _timeTrackingContext = timeTrackingContext;
            _dbSet = _timeTrackingContext.Set<Reminder>();
        }

       
        public async Task AddReminderAsync(Reminder reminder, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(reminder, cancellationToken);
            await _timeTrackingContext.SaveChangesAsync();
        }

        public async Task DeleteReminderAsync(Reminder reminder, CancellationToken cancellationToken)
        {
            _dbSet.Remove(reminder);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<Reminder>> GetAllRemindersAsync(CancellationToken cancellationToken)
        {
            var reminders = await _dbSet.ToListAsync(cancellationToken);
            return reminders;
        }

        public async Task<Reminder> GetReminderByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var reminder = await _dbSet.FindAsync(id, cancellationToken);
            return reminder;
        }

        public async Task UpdateReminderAsync(Reminder reminder, CancellationToken cancellationToken)
        {
            _dbSet.Update(reminder);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }
    }
}
