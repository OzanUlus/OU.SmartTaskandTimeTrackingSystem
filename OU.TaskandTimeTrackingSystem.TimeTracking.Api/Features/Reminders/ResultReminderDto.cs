namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders
{
    public record ResultReminderDto
    {
        public Guid TimeEntryId { get; set; }
       

        public DateTime ReminderTime { get; set; }
        public bool IsSent { get; set; }
    }
}
