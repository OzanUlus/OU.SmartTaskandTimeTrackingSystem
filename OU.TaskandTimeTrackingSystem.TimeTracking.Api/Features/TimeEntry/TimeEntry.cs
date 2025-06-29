using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Tags;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry
{
    public class TimeEntry : BaseEntity
    {
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public TimeSpan? Duration => EndTime.HasValue ? EndTime.Value - StartTime : null;
        public string? Note { get; set; }

        public IEnumerable<BreakPeriod.BreakPeriod>? BreakPeriods { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
