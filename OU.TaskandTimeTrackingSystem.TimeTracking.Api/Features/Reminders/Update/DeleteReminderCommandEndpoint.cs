using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Delete;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Update
{
    public static class DeleteReminderCommandEndpoint
    {
        public static RouteGroupBuilder DeleteReminderGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapDelete("/{id:guid}", async (Guid id, IMediator mediator) => (await mediator.Send(new DeleteReminderCommand(id)))).WithName("DeleteReminder").WithSummary("DeleteReminder");

            return group;


        }
    }
}
