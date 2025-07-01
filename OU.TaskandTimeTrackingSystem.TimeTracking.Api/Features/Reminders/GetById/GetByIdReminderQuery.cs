using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetById
{
    public record GetByIdReminderQuery(Guid Id) : IRequest<SharedResult>
    {
    }
}
