using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetByIdAsync;

    public record GetByIdAsyncQuery(Guid Id) : IRequest<SharedResult>;
    
    

