using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Concretes
{
    public class BreakPeriodRepository : IBreakPeriodRepository
    {
        private readonly TimeTrackingContext _timeTrackingContext;
        private readonly DbSet<BreakPeriod> _dbSet;

        public BreakPeriodRepository(TimeTrackingContext timeTrackingContext)
        {
            _timeTrackingContext = timeTrackingContext;
            _dbSet = _timeTrackingContext.Set<BreakPeriod>();
        }


        public async Task AddBreakPeriodAsync(BreakPeriod breakPeriod, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(breakPeriod, cancellationToken);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<BreakPeriod>> GetBreakPeriodsByTimeEntryIdAsync(Guid timeEntryId, CancellationToken cancellationToken)
        {
            var periods = await _dbSet.Where(bp => bp.TimeEntryId == timeEntryId).ToListAsync(cancellationToken);
            return periods;
        }

   
        public async Task StopBreakPeriodAsync(Guid breakPeriodId, DateTime EndTime, CancellationToken cancellationToken)
        {
            var period = await _dbSet.FindAsync(breakPeriodId, cancellationToken);
            period!.EndTime = EndTime;
            period.Duration = period.EndTime - period.StartTime;
            _dbSet.Update(period);
            await _timeTrackingContext.SaveChangesAsync(cancellationToken);
        }

      
    }
}
