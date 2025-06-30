namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod
{
    public record ResultBreakPeriodDto
    {
        public Guid Id { get; set; }
        public Guid TimeEntryId { get; set; }
      
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan? Duration { get; set; }
    }
}
