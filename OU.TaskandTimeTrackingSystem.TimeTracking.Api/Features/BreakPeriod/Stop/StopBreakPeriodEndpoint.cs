using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Stop;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Stop
{
    public static class StopBreakPeriodEndpoint
    {
        public static RouteGroupBuilder StopBreakPeriodGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPut("/", async (StopBreakPeriodCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("StopBreakPeriod").WithSummary("StopBreakPeriod");

            return group;


        }
    }
}
