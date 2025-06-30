using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces
{
    public interface IBreakPeriodRepository
    {
        Task AddBreakPeriodAsync(BreakPeriod breakPeriod, CancellationToken cancellationToken);
        Task StopBreakPeriodAsync(Guid breakPeriodId, DateTime EndTime, CancellationToken cancellationToken);
        Task<IEnumerable<BreakPeriod>> GetBreakPeriodsByTimeEntryIdAsync(Guid timeEntryId, CancellationToken cancellationToken);
    }
}
