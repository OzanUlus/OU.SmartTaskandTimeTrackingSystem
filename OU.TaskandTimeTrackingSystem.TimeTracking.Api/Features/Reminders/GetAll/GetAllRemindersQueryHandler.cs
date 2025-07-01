
using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetAll
{
    public class GetAllRemindersQueryHandler(IReminderRepository reminderRepository) : IRequestHandler<GetAllRemindersQuery, SharedResult>
    {
        public async Task<SharedResult> Handle(GetAllRemindersQuery request, CancellationToken cancellationToken)
        {
            var reminders = await reminderRepository.GetAllRemindersAsync(cancellationToken);
            if (reminders != null)
            {
                var resultDto = reminders.Adapt<IEnumerable<ResultReminderDto>>();
                return new SuccessDataResult<IEnumerable<ResultReminderDto>>(resultDto,"Reminders listed successfully.");
            }
            return new ErrorResult("Reminders not found.");
        }
    }
}
