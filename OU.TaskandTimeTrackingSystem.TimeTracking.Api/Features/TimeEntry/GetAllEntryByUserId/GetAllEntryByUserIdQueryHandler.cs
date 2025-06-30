using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Dto;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetAllEntryByUserId
{
    public class GetAllEntryByUserIdQueryHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<GetAllEntryByUserIdQuery, SharedResult>
    {
        public async Task<SharedResult> Handle(GetAllEntryByUserIdQuery request, CancellationToken cancellationToken)
        {
            var entries = await timeEntryRepository.GetAllEntryByUserId(request.UserId, cancellationToken);
            if (entries == null) return new ErrorResult("TimeEntries not found by UserId");
            var resultDto = entries.Adapt<IEnumerable<ResultTimeEntryDto>>();
            return new SuccessDataResult<IEnumerable<ResultTimeEntryDto>>(resultDto,"TimeEntries listed successfully by UserId");
        }
    }
}
