using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders
{
    public static class ReminderEndpointExt
    {
        public static void ReminderGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/reminder").WithTags("Reminders")

                .CreateReminderGroupItemEndpoint();
             



        }
    }
}
