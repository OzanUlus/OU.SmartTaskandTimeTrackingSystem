namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.Category
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/categories").WithTags("Categories")

                .CreateCategoryGroupItemEndpoint()
                .GetAllCategoriesGroupItemEndpoint()
                .GetByIdCategoryGroupItemEndpoint()
                .UpdateCategoryGroupItemEndpoint()
                .DeleteCategoryGroupItemEndpoint();
                


        }
    }
}
