using SmartTaskandTimeTrackingSystem.Api.Enpoints.TaskItem;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.TaskItem
{
    public static class TaskItemEndpointExt
    {
        public static void AddTakItemGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/taskItems").WithTags("TaskItems")

                .CreateTaskItemGroupItemEndpoint()
                .GetAllTaskItemsGroupItemEndpoint()
                .GetByIdTaskItemGroupItemEndpoint()
                .UpdateTaskItemGroupItemEndpoint()
                .DeleteTaskItemGroupItemEndpoint();



        }
    }
}
