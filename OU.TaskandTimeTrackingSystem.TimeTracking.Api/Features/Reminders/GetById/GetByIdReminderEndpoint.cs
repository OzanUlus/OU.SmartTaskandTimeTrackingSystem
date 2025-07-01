using MediatR;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetById
{
    public static class GetByIdReminderEndpoint
    {
        public static RouteGroupBuilder GetByIdReminderGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/{id:guid}", async (Guid id, IMediator mediator) => (await mediator.Send(new GetByIdReminderQuery(id)))).WithName("GetByIdReminder").WithSummary("GetByIdReminder");

            return group;


        }
    }
}
