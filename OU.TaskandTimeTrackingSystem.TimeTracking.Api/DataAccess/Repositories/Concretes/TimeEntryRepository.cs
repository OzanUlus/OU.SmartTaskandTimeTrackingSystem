using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;

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

        
        public async Task DeleteAsync(TimeEntry timeEntry)
        {
            _dbSet.Remove(timeEntry);
            await _timeTrackingContext.SaveChangesAsync();
            
        }

        public async Task<TimeEntry> GetActiveEntryByUserId(Guid userId)
        {
            var activeEntry = await _dbSet.Where(te => te.UserId == userId  &&  te.EndTime == null).OrderByDescending(te => te.StartTime).FirstOrDefaultAsync();
            return activeEntry;

        }

        public async Task<IEnumerable<TimeEntry>> GetActivesEntryByUserId(Guid userId)
        {
            var activeEntries = await _dbSet.Where(te => te.UserId == userId && te.EndTime == null).OrderByDescending(te => te.StartTime).ToListAsync();
            return activeEntries;
        }

        public async Task<IEnumerable<TimeEntry>> GetAllEntryByUserId(Guid userId)
        {
            var activeEntries = await _dbSet.Where(te => te.UserId == userId).OrderByDescending(te => te.StartTime).ToListAsync();
            return activeEntries;
        }

        public async Task<TimeEntry?> GetByIdAsync(Guid id)
        {
            var timeEntry = await _dbSet.FindAsync(id);
            return timeEntry;
        }

       

        public async Task StartTrackingAsync(TimeEntry timeEntry)
        {
            await _dbSet.AddAsync(timeEntry);
            await _timeTrackingContext.SaveChangesAsync();
        }

        public async Task StopTrackingAsync(TimeEntry timeEntry)
        {
           
            _dbSet.Update(timeEntry);
            await _timeTrackingContext.SaveChangesAsync();
        }
    }
}
