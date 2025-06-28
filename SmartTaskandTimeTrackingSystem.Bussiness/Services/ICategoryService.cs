using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace SmartTaskandTimeTrackingSystem.Bussiness.Services
{
    public interface ICategoryService
    {
        Task<IResult> GetCategoryAsync(Guid categoryId);
        Task<IResult> GetAllCategoryAsync();
        Task<IResult> AddCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<IResult> DeleteCategoryAsync(Guid categoryId);
        Task<IResult> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
    }
}
