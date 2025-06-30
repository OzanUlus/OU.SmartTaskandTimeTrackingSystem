using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;
using System.Threading;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Concretes
{
    public class TimeEntryRepository : ITimeEntryRepository
    {
        private readonly TimeTrackingContext _timeTrackingContext;
        private readonly DbSet<TimeEntry> _dbSet;

        public TimeEntryRepository(TimeTrackingContext timeTrackingContext)
        {
            _timeTrackingContext = timeTrackingContext;
            _dbSet = _timeTrackingContext.Set<TimeEntry>();
        }

        
        public async Task DeleteAsync(TimeEntry timeEntry, CancellationToken cancellationToken)
        {
            _dbSet.Remove(timeEntry);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
            
        }

        public async Task<TimeEntry> GetActiveEntryByUserId(Guid userId, CancellationToken cancellationToken)
        {
            var activeEntry = await _dbSet.Where(te => te.UserId == userId  &&  te.EndTime == null).OrderByDescending(te => te.StartTime).FirstOrDefaultAsync(cancellationToken);
            return activeEntry;

        }

        public async Task<IEnumerable<TimeEntry>> GetActivesEntryByUserId(Guid userId, CancellationToken cancellationToken)
        {
            var activeEntries = await _dbSet.Where(te => te.UserId == userId && te.EndTime == null).OrderByDescending(te => te.StartTime).ToListAsync(cancellationToken);
            return activeEntries;
        }

        public async Task<IEnumerable<TimeEntry>> GetAllEntryByUserId(Guid userId, CancellationToken cancellationToken)
        {
            var activeEntries = await _dbSet.Where(te => te.UserId == userId).OrderByDescending(te => te.StartTime).ToListAsync(cancellationToken);
            return activeEntries;
        }

        public async Task<TimeEntry?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var timeEntry = await _dbSet.FindAsync(id, cancellationToken);
            return timeEntry;
        }

       

        public async Task StartTrackingAsync(TimeEntry timeEntry, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(timeEntry);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }

        public async Task StopTrackingAsync(TimeEntry timeEntry, CancellationToken cancellationToken)
        {
           
            _dbSet.Update(timeEntry);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }
    }
}
