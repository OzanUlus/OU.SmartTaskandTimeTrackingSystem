
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Concretes;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Delete
{
    public class DeleteReminderCommandHandler(IReminderRepository reminderRepository) : IRequestHandler<DeleteReminderCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(DeleteReminderCommand request, CancellationToken cancellationToken)
        {
            var reminder = await reminderRepository.GetReminderByIdAsync(request.Id, cancellationToken);
            if (reminder == null) return new ErrorResult("Reminder not found.");
            await reminderRepository.DeleteReminderAsync(reminder, cancellationToken);
            return new SuccessResult("Reminder deleted successfuly");
        }
    }
}
