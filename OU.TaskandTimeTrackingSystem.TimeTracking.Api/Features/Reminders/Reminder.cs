using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders
{
    public class Reminder : BaseEntity
    {
        public Guid TimeEntryId { get; set; }
        public TimeEntry.TimeEntry TimeEntry { get; set; } = null!;

        public DateTime ReminderTime { get; set; }
        public bool IsSent { get; set; } = false;

    }
}
