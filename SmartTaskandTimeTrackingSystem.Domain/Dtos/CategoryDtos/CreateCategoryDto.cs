namespace SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos
{
    public record CreateCategoryDto
    {
        public string CategoryName { get; set; } = default!;
        public string? CategoryCode { get; set; }
    }
}
