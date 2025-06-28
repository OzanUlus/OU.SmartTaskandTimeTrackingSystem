namespace SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos
{
    public record ResultCategoryDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; } = default!;
        public string? CategoryCode { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
