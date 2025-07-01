using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Delete;

    public record DeleteReminderCommand(Guid Id) : IRequest<SharedResult>;
    
    

