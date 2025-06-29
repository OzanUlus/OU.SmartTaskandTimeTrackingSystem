using MediatR;
using Microsoft.AspNetCore.Mvc;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId
{
    public static class GetActivesEntryByUserIdEndpoint
    {
        public static RouteGroupBuilder GetActivesEntryByUserIdGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/{userId:guid}", async (Guid userId, [FromServices] IMediator mediator) => (await mediator.Send(new GetActivesEntryByUserIdQuery(userId)))).WithName("GetActivesEntryByUserId");

            return group;


        }
    }
}
