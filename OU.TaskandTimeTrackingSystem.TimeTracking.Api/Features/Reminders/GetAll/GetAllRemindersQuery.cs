using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetAll
{
    public record GetAllRemindersQuery : IRequest<SharedResult>
    {
    }
}
