using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Delete
{
    public static class DeleteTimeEntryEndpoint
    {
        public static RouteGroupBuilder DeleteTimeEntryGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapDelete("/{id:guid}", async (Guid Id, [FromServices] IMediator mediator) => (await mediator.Send(new DeleteTimeEntryCommand(Id)))).WithName(" DeleteTimeEntry").WithSummary(" DeleteTimeEntry");

            return group;


        }
    }
}
