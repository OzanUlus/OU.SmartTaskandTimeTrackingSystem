using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId
{
    public static class GetActivesEntryByUserIdEndpoint
    {
        public static RouteGroupBuilder GetActivesEntryByUserIdGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/active/{userId:guid}", async (Guid userId, [FromServices] IMediator mediator) => (await mediator.Send(new GetActivesEntryByUserIdQuery(userId)))).WithName("GetActivesEntryByUserId").WithSummary("GetActivesEntryByUserId");

            return group;


        }
    }
}
