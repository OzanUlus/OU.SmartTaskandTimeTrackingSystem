using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ManuelTimeAdjustments
{
    public class ManuelTimeAdjustment : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid? RelatedTimeEntryId { get; set; }

        public DateTime AdjustmentDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Reason { get; set; } = default!;

    }
}
