using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Delete;

    public record DeleteTimeEntryCommand(Guid Id) : IRequest<SharedResult>;
    
    

