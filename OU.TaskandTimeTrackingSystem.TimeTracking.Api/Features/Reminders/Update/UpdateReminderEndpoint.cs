using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Update
{
    public static class UpdateReminderEndpoint
    {
        public static RouteGroupBuilder UpdateReminderGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPut("/", async (UpdateReminderCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("UpdateReminder").WithSummary("UpdateReminder");

            return group;


        }
    }
}
