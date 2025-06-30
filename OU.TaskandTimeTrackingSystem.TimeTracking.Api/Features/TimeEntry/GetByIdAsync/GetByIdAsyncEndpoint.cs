using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetByIdAsync
{
    public static class GetByIdAsyncEndpoint
    {
        public static RouteGroupBuilder GetByIdAsyncGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/get/{id:guid}", async (Guid id, [FromServices] IMediator mediator) => (await mediator.Send(new GetByIdAsyncQuery(id)))).WithName("GetByIdAsync").WithSummary("GetByIdAsync");

            return group;


        }
    }
}
