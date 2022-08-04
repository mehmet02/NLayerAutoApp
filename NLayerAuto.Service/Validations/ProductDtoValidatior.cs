using FluentValidation;
using NLayerAuto.Core.DTOs;

namespace NLayerAuto.Service.Validations;

public class ProductDtoValidatior:AbstractValidator<CarsDto>
{
    public ProductDtoValidatior()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{ProperyName} is required");
        RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater 0");
    }
}