using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Dto;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActiveEntryByUserId
{
    public class GetActiveEntryByUserIdQueryHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<GetActiveEntryByUserIdQuery, SharedResult>
    {
        public async Task<SharedResult> Handle(GetActiveEntryByUserIdQuery request, CancellationToken cancellationToken)
        {
            var entry = await timeEntryRepository.GetActiveEntryByUserId(request.UserId, cancellationToken);
            if (entry == null) return new ErrorResult("TimeEntry not found.");
            var resultDto = entry.Adapt<ResultTimeEntryDto>();
            return new SuccessDataResult<ResultTimeEntryDto>(resultDto, "TimeEntry found successfully.");
        }
    }
}
