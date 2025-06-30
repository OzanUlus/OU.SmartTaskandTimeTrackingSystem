using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod
{
    public class BreakPeriod : BaseEntity
    {
        public Guid TimeEntryId { get; set; }
        public TimeEntry.TimeEntry TimeEntry { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan? Duration { get; set; } 
    }
}
