using FluentValidation;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create
{
    public class CreateTimeEntryCommandValidator : AbstractValidator<CreateTimeEntryCommand>
    {
        public CreateTimeEntryCommandValidator()
        {
            RuleFor(x => x.TaskId)
                .NotEmpty().WithMessage("Task ID cannot be empty.")
                .NotEqual(Guid.Empty).WithMessage("A valid Task ID must be provided.");

            RuleFor(x => x.StartTime)
                .NotEmpty().WithMessage("Start time cannot be empty.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Start time cannot be in the future.");

            RuleFor(x => x.Note)
                .MaximumLength(255).WithMessage("Note can be at most 255 characters long.")
                .When(x => !string.IsNullOrWhiteSpace(x.Note));
        }
    }
}
