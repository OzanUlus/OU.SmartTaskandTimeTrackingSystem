
using Mapster;
using MassTransit;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create
{
    public class CreateBreakPeriodCommandHandler(IBreakPeriodRepository breakPeriodRepository) : IRequestHandler<CreateBreakPeriodCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(CreateBreakPeriodCommand request, CancellationToken cancellationToken)
        {
            var period = request.Adapt<BreakPeriod>();
            period.Id = NewId.NextSequentialGuid();
            period.StartTime = DateTime.UtcNow;
            await breakPeriodRepository.AddBreakPeriodAsync(period, cancellationToken);
            return new SuccessResult("BreakPeriod added successfully");
        }
    }
}
