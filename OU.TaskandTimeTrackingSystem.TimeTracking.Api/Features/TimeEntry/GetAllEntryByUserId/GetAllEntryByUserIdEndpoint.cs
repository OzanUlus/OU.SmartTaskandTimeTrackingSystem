using MediatR;
using Microsoft.AspNetCore.Mvc;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetAllEntryByUserId
{
    public static class GetAllEntryByUserIdEndpoint
    {
        public static RouteGroupBuilder GetAllEntryByUserIdGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/{userId:guid}", async (Guid userId, [FromServices] IMediator mediator) => (await mediator.Send(new GetAllEntryByUserIdQuery(userId)))).WithName("GetAllEntryByUserId").WithSummary("GetAllEntryByUserId");

            return group;


        }
    }
}
