using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create
{
    public static class CreateBreakPeriodEndpoint
    {
        public static RouteGroupBuilder CreateBreakPeriodGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPost("/", async (CreateBreakPeriodCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("CreateBreakPeriod").WithSummary("CreateBreakPeriod");

            return group;


        }
    }
}
