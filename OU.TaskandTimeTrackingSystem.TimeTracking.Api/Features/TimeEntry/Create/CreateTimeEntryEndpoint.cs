using MediatR;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create
{
    public static class CreateTimeEntryEndpoint
    {
        public static RouteGroupBuilder CreateTimeEntryGroupItemEndpoint(this RouteGroupBuilder group)
        {

             group.MapPost("/", async (CreateTimeEntryCommand command, IMediator mediator) => (await mediator.Send(command))).WithName("CreateTimeEntry").AddEndpointFilter<ValidationFilter<CreateTimeEntryCommandValidator>>();

            return group;


        }
    }
}
