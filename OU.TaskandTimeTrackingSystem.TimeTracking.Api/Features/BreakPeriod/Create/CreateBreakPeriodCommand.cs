using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create;

    public record CreateBreakPeriodCommand(Guid TimeEntryId): IRequest<SharedResult>;
    
    

