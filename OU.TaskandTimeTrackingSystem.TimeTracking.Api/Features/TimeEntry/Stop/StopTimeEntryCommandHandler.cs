using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Stop
{
    public class StopTimeEntryCommandHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<StopTimeEntryCommand, Result>
    {
        public async Task<Result> Handle(StopTimeEntryCommand request, CancellationToken cancellationToken)
        {
            var entry = await timeEntryRepository.GetByIdAsync(request.EntryId);
            if (entry == null) return new ErrorResult("TimeEntry not found");

            entry.EndTime = request.EndTime;
            entry.Duration = request.EndTime - entry.StartTime;
            await timeEntryRepository.StopTrackingAsync(entry);
            return new SuccessResult("TimeTrackin stoped succesfully");
        }
    }
}
