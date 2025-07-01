using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create
{
    public record CreateReminderCommand(Guid TimeEntryId, DateTime ReminderTime, bool IsSent) : IRequest<SharedResult>
    {
    }
}
