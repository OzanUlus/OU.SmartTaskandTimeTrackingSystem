using MediatR;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Stop;

    public record StopBreakPeriodCommand() : IRequest<SharedResult>
{
    public Guid Id { get; set; }
    public DateTime EndTime { get; set; } = DateTime.Now;
}
    
   
