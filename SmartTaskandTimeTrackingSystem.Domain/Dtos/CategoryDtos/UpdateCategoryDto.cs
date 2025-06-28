namespace SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos
{
    public record UpdateCategoryDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; } = default!;
        public string? CategoryCode { get; set; }
    }
}
