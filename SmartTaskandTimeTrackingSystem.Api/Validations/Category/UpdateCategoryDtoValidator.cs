using FluentValidation;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;

namespace SmartTaskandTimeTrackingSystem.Api.Validations.Category
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
          

            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Category name is required.")
                .MaximumLength(128).WithMessage("Category name must not exceed 128 characters.");

            RuleFor(c => c.CategoryCode)
                .MaximumLength(32).WithMessage("Category code must not exceed 32 characters.");

        }
    }
}
