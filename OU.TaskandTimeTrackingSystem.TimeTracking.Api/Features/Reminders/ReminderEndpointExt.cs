using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetAll;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetById;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Update;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders
{
    public static class ReminderEndpointExt
    {
        public static void ReminderGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/reminder").WithTags("Reminders")

                .CreateReminderGroupItemEndpoint()
                .GetAllReminderGroupItemEndpoint()
                .GetByIdReminderGroupItemEndpoint()
                .UpdateReminderGroupItemEndpoint()
                .DeleteReminderGroupItemEndpoint();
             



        }
    }
}
