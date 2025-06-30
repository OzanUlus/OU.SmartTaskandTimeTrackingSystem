using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Dto;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId
{
    public class GetActivesEntryByUserIdQueryHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<GetActivesEntryByUserIdQuery, SharedResult>
    {
        public async Task<SmartTaskandTimeTrackingSystem.Shared.Result.IResult> Handle(GetActivesEntryByUserIdQuery request, CancellationToken cancellationToken)
        {
            var entries = await timeEntryRepository.GetActivesEntryByUserId(request.UserId, cancellationToken);
            if (entries == null) return new ErrorResult("TimeEntries not found.");
            var entryDto = entries.Adapt<List<ResultTimeEntryDto>>();
            return new SuccessDataResult<List<ResultTimeEntryDto>>(entryDto, "TimeEntries listed successfully.");
        }
    }
}
