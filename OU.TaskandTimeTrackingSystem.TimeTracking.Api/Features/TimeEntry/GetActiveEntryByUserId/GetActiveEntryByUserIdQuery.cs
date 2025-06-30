using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActiveEntryByUserId;

    public record GetActiveEntryByUserIdQuery(Guid UserId) : IRequest<SharedResult>;
    
    

