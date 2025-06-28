using Microsoft.AspNetCore.Mvc;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class UpdateCategoryEndpoint
    {
        public static RouteGroupBuilder UpdateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {

            var result = group.MapPut("/", async ([FromBody] UpdateCategoryDto updateCategoryDto, [FromServices]ICategoryService categoryService) => (await categoryService.UpdateCategoryAsync(updateCategoryDto))).WithName(" UpdateCategory").AddEndpointFilter<ValidationFilter<UpdateCategoryDto>>();

            return group;


        }
    }
}
