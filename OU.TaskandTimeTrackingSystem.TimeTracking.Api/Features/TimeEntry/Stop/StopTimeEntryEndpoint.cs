using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Stop
{
    public static class StopTimeEntryEndpoint
    {
        public static RouteGroupBuilder StopTimeEntryGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPut("/", async (StopTimeEntryCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("StopTimeEntry").WithSummary("StopTimeEntry");

            return group;


        }
    }
}
