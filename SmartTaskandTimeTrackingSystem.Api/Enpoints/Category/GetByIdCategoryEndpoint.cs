using SmartTaskandTimeTrackingSystem.Bussiness.Services;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class GetByIdCategoryEndpoint
    {
        public static RouteGroupBuilder GetByIdCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {

            var result = group.MapGet("/{id:guid}", async (ICategoryService categoryService, Guid id) => (await categoryService.GetCategoryAsync(id))).WithName(" GetByIdCategory");

            return group;


        }
    }
}
