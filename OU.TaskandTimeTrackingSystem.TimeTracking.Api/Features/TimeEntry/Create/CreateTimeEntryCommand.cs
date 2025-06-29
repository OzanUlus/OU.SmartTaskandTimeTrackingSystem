using MediatR;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create;

    public record CreateTimeEntryCommand(Guid TaskId, DateTime StartTime, string Note): IRequest<SuccessResult>;
    
    

