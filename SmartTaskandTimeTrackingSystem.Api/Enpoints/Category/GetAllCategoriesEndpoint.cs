using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class GetAllCategoriesEndpoint
    {
        public static RouteGroupBuilder GetAllCategoriesGroupItemEndpoint(this RouteGroupBuilder group)
        {

            var result = group.MapGet("/", async (ICategoryService categoryService) => (await categoryService.GetAllCategoryAsync())).WithName("GetAllCategories");

            return group;


        }
    }
}
