namespace SmartTaskandTimeTrackingSystem.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = default!;
        public string? CategoryCode { get; set; }

        public IEnumerable<TaskItem>? TaskItems { get; set; }
    }
}
