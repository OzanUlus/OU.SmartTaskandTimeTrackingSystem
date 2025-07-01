using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetAll
{
    public static class GetAllReminderEndpoint
    {
        public static RouteGroupBuilder GetAllReminderGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/", async (IMediator mediator) => (await mediator.Send(new GetAllRemindersQuery()))).WithName("GetAllReminders").WithSummary("GetAllReminders");

            return group;


        }
    }
}
