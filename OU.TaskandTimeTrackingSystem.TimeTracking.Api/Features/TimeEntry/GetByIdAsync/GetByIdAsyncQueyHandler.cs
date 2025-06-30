using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Dto;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using ShareResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetByIdAsync
{
    public class GetByIdAsyncQueyHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<GetByIdAsyncQuery, ShareResult>
    {
        public async Task<ShareResult> Handle(GetByIdAsyncQuery request, CancellationToken cancellationToken)
        {
            var entry = await timeEntryRepository.GetByIdAsync(request.Id, cancellationToken);
            if (entry == null) return new ErrorResult("Entry not found.");
            var resultDto = entry.Adapt<ResultTimeEntryDto>();
            return new SuccessDataResult<ResultTimeEntryDto>(resultDto, "TimeEntry found successfully");
        }
    }
}
