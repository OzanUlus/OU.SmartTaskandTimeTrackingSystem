
using Mapster;
using MassTransit;
using MediatR;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SharedResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Create
{
    public class CreateReminderCommandHandler(IReminderRepository reminderRepository) : IRequestHandler<CreateReminderCommand, SharedResult>
    {
        public async Task<SharedResult> Handle(CreateReminderCommand request, CancellationToken cancellationToken)
        {
            var reminder = request.Adapt<Reminder>();
            reminder.Id = NewId.NextSequentialGuid();
            reminder.IsSent = false;
            await reminderRepository.AddReminderAsync(reminder, cancellationToken);
            return new SuccessResult("Reminder added successfully.");
        }
    }
}
