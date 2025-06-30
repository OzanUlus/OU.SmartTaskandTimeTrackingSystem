using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SmartTaskandTimeTrackingSystem.Shared.Services;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create
{
    public class CreateTimeEntryCommandHandler(ITimeEntryRepository timeEntryRepository, IIdentityService identityService) : IRequestHandler<CreateTimeEntryCommand, SuccessResult>
    {
        public async Task<SuccessResult> Handle(CreateTimeEntryCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<TimeEntry>();
            entity.UserId = identityService.GetUserId;
            await timeEntryRepository.StartTrackingAsync(entity, cancellationToken);
            return new SuccessResult("TimeTracking started.");
        }
    }
}
