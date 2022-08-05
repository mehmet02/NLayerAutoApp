using FluentValidation;
using NLayerAuto.Core.DTOs;

namespace NLayerAuto.Service.Validations;

public class CarsDtoValidatior:AbstractValidator<Cars2Dto>
{
    public CarsDtoValidatior()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{ProperyName} is required");
        RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater 0");
    }
}