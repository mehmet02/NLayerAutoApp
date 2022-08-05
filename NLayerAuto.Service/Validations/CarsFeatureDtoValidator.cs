using FluentValidation;
using NLayerAuto.Core.DTOs;

namespace NLayerAuto.Service.Validations;

public class CarsFeatureDtoValidator: AbstractValidator<CarsFeatureDto>
{
    public CarsFeatureDtoValidator()
    {
        RuleFor(x => x.Color).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{ProperyName} is required");
        RuleFor(x => x.CarsId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater 0");
    }
}