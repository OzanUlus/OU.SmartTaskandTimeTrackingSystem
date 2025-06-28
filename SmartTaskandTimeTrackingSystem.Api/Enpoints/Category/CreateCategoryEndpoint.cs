using Microsoft.AspNetCore.Mvc;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group) 
        {

            var result = group.MapPost("/", async ([FromBody] CreateCategoryDto createCategoryDto, ICategoryService categoryService) => (await categoryService.AddCategoryAsync(createCategoryDto))).WithName("CreateCategory").AddEndpointFilter<ValidationFilter<CreateCategoryDto>>();
            
            return group;

            
        }
    }
}
