using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Tags
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; } = default!;

        public IEnumerable<TimeEntry.TimeEntry> TimeEntries { get; set; }
    }
}
