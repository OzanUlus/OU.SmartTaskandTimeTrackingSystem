namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Dto
{
    public record ResultTimeEntryDto
    {
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public TimeSpan? Duration { get; set; }
        public string? Note { get; set; }

    }
}
