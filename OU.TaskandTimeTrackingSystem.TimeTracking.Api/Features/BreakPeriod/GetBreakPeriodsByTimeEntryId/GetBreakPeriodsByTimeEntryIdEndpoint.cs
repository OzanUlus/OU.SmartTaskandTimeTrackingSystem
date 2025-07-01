using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.GetBreakPeriodsByTimeEntryId
{
    public static class GetBreakPeriodsByTimeEntryIdEndpoint
    {
        public static RouteGroupBuilder GetBreakPeriodsByTimeEntryIdGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapGet("/{timeEntryId:guid}", async (Guid timeEntryId, IMediator mediator) => (await mediator.Send(new GetBreakPeriodsByTimeEntryIdQuery(timeEntryId)))).WithName(" GetBreakPeriodsByTimeEntryId").WithSummary(" GetBreakPeriodsByTimeEntryId");

            return group;


        }
    }
}
