using SmartTaskandTimeTrackingSystem.Domain.Enums;

namespace SmartTaskandTimeTrackingSystem.Domain.Dtos.TaskItemDtos
{
    public record CreateTaskItemDto
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public string? TaskCode { get; set; }
        public TaskPriority Priority { get; set; }
        public Enums.TaskStatus Status { get; set; }
      
        public Guid CategoryId { get; set; }
    }
}
