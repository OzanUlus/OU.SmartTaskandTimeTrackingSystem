using FluentValidation;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.TaskItemDtos;

namespace SmartTaskandTimeTrackingSystem.Api.Validations.TaskItem
{
    public class CreateTaskItemDtoValidator : AbstractValidator<CreateTaskItemDto>
    {
        public CreateTaskItemDtoValidator()
        {
            RuleFor(t => t.Title)
                 .NotEmpty().WithMessage("Title is required.")
                 .MaximumLength(255).WithMessage("Title must not exceed 255 characters.");

            RuleFor(t => t.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(512).WithMessage("Description must not exceed 512 characters.");

            RuleFor(t => t.TaskCode)
                .MaximumLength(32).WithMessage("Task code must not exceed 32 characters.");

        }
    }
}
