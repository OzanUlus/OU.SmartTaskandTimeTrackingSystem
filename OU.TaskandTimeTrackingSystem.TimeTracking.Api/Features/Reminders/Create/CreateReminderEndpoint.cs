using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create
{
    public static class CreateReminderEndpoint
    {
        public static RouteGroupBuilder CreateReminderGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPost("/", async (CreateReminderCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("CreateReminder").WithSummary("CreateReminder");

            return group;


        }
    }
}
