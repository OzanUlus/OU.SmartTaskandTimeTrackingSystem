using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.GetBreakPeriodsByTimeEntryId;

    public record GetBreakPeriodsByTimeEntryIdQuery(Guid TİmeEntryId) : IRequest<SharedResult>;
    
    

