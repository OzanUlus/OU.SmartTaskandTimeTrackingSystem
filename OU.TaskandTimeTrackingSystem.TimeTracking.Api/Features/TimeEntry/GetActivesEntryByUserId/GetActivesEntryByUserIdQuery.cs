using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId;

    public record GetActivesEntryByUserIdQuery(Guid UserId): IRequest<SharedResult>;
    
    

