using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ActivityLogs
{
    public class ActivityLog : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Action { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
