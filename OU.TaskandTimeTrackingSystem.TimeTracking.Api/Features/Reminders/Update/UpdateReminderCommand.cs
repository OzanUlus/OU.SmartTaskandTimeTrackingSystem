using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Update
{
    public record UpdateReminderCommand(Guid Id, Guid TimeEntryId, DateTime ReminderTime, bool IsSent) : IRequest<SharedResult>
    {
    }
}
