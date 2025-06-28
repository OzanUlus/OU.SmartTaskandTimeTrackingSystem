using Mapster;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;
using SmartTaskandTimeTrackingSystem.Domain.Entities;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace SmartTaskandTimeTrackingSystem.Bussiness.Managers
{
    public class CategoryManager(ICategoryRepository categoryRepository) : ICategoryService
    {
        public async Task<IResult> AddCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var category = createCategoryDto.Adapt<Category>();
            await categoryRepository.CreateAsync(category);
            return new SuccessResult("Category created successfully.");
        }

        public async Task<IResult> DeleteCategoryAsync(Guid categoryId)
        {
            var category = await categoryRepository.GetByIdAsync(categoryId);
            if (category is null) return new ErrorResult("Category not found.");
            await categoryRepository.DeleteAsync(category);
            return new SuccessResult("Category deleted successfully.");
        }

        public async Task<IResult> GetAllCategoryAsync()
        {
            var categories = await categoryRepository.GetAllAsync();
            if (categories is null) return new ErrorResult("Categories not found.");
            var categoriesDto = categories.Adapt<IEnumerable<ResultCategoryDto>>();
            return new SuccessDataResult<IEnumerable<ResultCategoryDto>>(categoriesDto, "Categories listed successfully.");
        }

        public async Task<IResult> GetCategoryAsync(Guid categoryId)
        {
            var category = await categoryRepository.GetByIdAsync(categoryId);
            if (category is null) return new ErrorResult("Category not found.");
            var categoryDto = category.Adapt<ResultCategoryDto>();
            return new SuccessDataResult<ResultCategoryDto>(categoryDto, "Category not found.");
        }

        public async Task<IResult> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var category = await categoryRepository.GetByIdAsync(updateCategoryDto.Id);
            if (category is null) return new ErrorResult("Category not found.");
            category.Id = updateCategoryDto.Id;
            category.CategoryName = updateCategoryDto.CategoryName;
            category.CategoryCode = updateCategoryDto.CategoryCode;
            await categoryRepository.UpdateAsync(category);
            return new SuccessResult("Category updated successfully.");
        }
    }
}
