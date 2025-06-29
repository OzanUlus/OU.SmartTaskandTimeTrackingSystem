using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces
{
    public interface ITimeEntryRepository
    {
        Task StartTrackingAsync(TimeEntry timeEntry);
        Task StopTrackingAsync(TimeEntry timeEntry);
        Task<IEnumerable<TimeEntry>> GetActivesEntryByUserId(Guid userId);
        Task<IEnumerable<TimeEntry>> GetAllEntryByUserId(Guid userId);
        Task<TimeEntry> GetActiveEntryByUserId(Guid userId);
        Task<TimeEntry?> GetByIdAsync(Guid id);
        Task DeleteAsync(TimeEntry timeEntry);
    }
}
