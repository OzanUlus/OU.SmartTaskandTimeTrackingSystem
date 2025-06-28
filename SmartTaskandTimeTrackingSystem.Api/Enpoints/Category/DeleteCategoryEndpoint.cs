using SmartTaskandTimeTrackingSystem.Bussiness.Services;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class DeleteCategoryEndpoint
    {
        public static RouteGroupBuilder DeleteCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {

            var result = group.MapDelete("/{id:guid}", async (ICategoryService categoryService, Guid id) => (await categoryService.DeleteCategoryAsync(id))).WithName(" DeleteCategory");

            return group;


        }
    }
}
