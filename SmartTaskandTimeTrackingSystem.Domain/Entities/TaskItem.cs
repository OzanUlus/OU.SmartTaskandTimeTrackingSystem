using SmartTaskandTimeTrackingSystem.Domain.Enums;

namespace SmartTaskandTimeTrackingSystem.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public string? TaskCode { get; set; }
        public TaskPriority Priority { get; set; }
        public Enums.TaskStatus Status { get; set; }
        public Guid UserId { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
