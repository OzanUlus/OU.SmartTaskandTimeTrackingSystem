using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActiveEntryByUserId
{
    public static class GetActiveEntryByUserIdEndpoint
    {
        public static RouteGroupBuilder GetActiveEntryByUserIdGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/getactive/{userId:guid}", async (Guid userId, [FromServices] IMediator mediator) => (await mediator.Send(new GetActiveEntryByUserIdQuery(userId)))).WithName("GetActiveEntryByUserId").WithSummary("GetActiveEntryByUserId");

            return group;


        }
    }
}
