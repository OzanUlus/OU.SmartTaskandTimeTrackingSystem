using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.WorkSessions
{
    public class WorkSession : BaseEntity
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TotalTrackedTime { get; set; }
        public int CompletedTasks { get; set; }

        public IEnumerable<TimeEntry.TimeEntry>? TimeEntries { get; set; } 

    }
}
