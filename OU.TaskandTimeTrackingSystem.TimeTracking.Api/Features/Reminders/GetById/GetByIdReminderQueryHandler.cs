
using Mapster;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.GetById
{
    public class GetByIdReminderQueryHandler(IReminderRepository reminderRepository) : IRequestHandler<GetByIdReminderQuery, SharedResult>
    {
        public async Task<SharedResult> Handle(GetByIdReminderQuery request, CancellationToken cancellationToken)
        {
            var reminder = await reminderRepository.GetReminderByIdAsync(request.Id, cancellationToken);
            if (reminder == null) return new ErrorResult("Reminder not found");
            var resultDto = reminder.Adapt<ResultReminderDto>();
            return new SuccessDataResult<ResultReminderDto>(resultDto, "Reminder found successfully");
        }
    }
}
