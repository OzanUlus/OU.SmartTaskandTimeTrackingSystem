
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Stop
{
    public class StopBreakPeriodCommandHandler(IBreakPeriodRepository breakPeriodRepository) : IRequestHandler<StopBreakPeriodCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(StopBreakPeriodCommand request, CancellationToken cancellationToken)
        {
            var period = await breakPeriodRepository.GetBreakPeriodByIdAsync(request.Id, cancellationToken);
            if (period == null) return new ErrorResult("BreakPeriod not found.");
            period.EndTime = request.EndTime;
            period.Duration = period.EndTime - period.StartTime;

            await breakPeriodRepository.StopBreakPeriodAsync(period, cancellationToken);
            return new SuccessResult("BreakPeriod stopped successfuly");
            
        }
    }
}
