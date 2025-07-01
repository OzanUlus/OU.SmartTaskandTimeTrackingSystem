
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Update
{
    public class UpdateReminderCommandHandler(IReminderRepository reminderRepository) : IRequestHandler<UpdateReminderCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(UpdateReminderCommand request, CancellationToken cancellationToken)
        {
            var reminder = await reminderRepository.GetReminderByIdAsync(request.Id, cancellationToken);
            if (reminder == null) return new ErrorResult("Reminder not found.");
            reminder.Id = request.Id;
            reminder.ReminderTime = request.ReminderTime;
            reminder.TimeEntryId = request.TimeEntryId;
            reminder.IsSent = false;
            await reminderRepository.UpdateReminderAsync(reminder, cancellationToken);
            return new SuccessResult("Reminder updated successfuly");
        }
    }
}
