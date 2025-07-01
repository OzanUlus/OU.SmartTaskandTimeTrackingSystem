
using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.GetBreakPeriodsByTimeEntryId
{
    public class GetBreakPeriodsByTimeEntryIdQueryHandler(IBreakPeriodRepository breakPeriodRepository) : IRequestHandler<GetBreakPeriodsByTimeEntryIdQuery, SharedResult>
    {
        public async Task<SharedResult> Handle(GetBreakPeriodsByTimeEntryIdQuery request, CancellationToken cancellationToken)
        {
            var periods = await breakPeriodRepository.GetBreakPeriodsByTimeEntryIdAsync(request.TİmeEntryId, cancellationToken);
            if (periods != null)
            {
               var resultDto = periods.Adapt<IEnumerable<ResultBreakPeriodDto>>();
                return new SuccessDataResult<IEnumerable<ResultBreakPeriodDto>>(resultDto, "BreakPeriods listed successfully by TimeEntryId");
            }

            return new ErrorResult("BreakPeriods not found.");
        }
    }
}
