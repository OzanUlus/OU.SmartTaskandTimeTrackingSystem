using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces
{
    public interface IBreakPeriodRepository
    {
        Task AddBreakPeriodAsync(BreakPeriod breakPeriod, CancellationToken cancellationToken);
        Task StopBreakPeriodAsync(BreakPeriod period, CancellationToken cancellationToken);
        Task<IEnumerable<BreakPeriod>> GetBreakPeriodsByTimeEntryIdAsync(Guid timeEntryId, CancellationToken cancellationToken);
        Task<BreakPeriod> GetBreakPeriodByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
