
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Delete
{
    public class DeleteTimeEntryCommandHandler(ITimeEntryRepository timeEntryRepository) : IRequestHandler<DeleteTimeEntryCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(DeleteTimeEntryCommand request, CancellationToken cancellationToken)
        {
            var entry = await timeEntryRepository.GetByIdAsync(request.Id, cancellationToken);
            if (entry != null)
            {
                await timeEntryRepository.DeleteAsync(entry, cancellationToken);
                return new SuccessResult("TimeEntry deleted successfully");
            }

           return new ErrorResult("TimeEntry not found.");
        }
    }
}
