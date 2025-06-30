using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces
{
    public interface ITimeEntryRepository
    {
        Task StartTrackingAsync(TimeEntry timeEntry, CancellationToken cancellationToken);
        Task StopTrackingAsync(TimeEntry timeEntry, CancellationToken cancellationToken);
        Task<IEnumerable<TimeEntry>> GetActivesEntryByUserId(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<TimeEntry>> GetAllEntryByUserId(Guid userId, CancellationToken cancellationToken);
        Task<TimeEntry> GetActiveEntryByUserId(Guid userId, CancellationToken cancellationToken);
        Task<TimeEntry?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task DeleteAsync(TimeEntry timeEntry, CancellationToken cancellationToken);
    }
}
