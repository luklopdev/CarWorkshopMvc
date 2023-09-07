using CarWorkshop.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDtoValidator : AbstractValidator<CarWorkshopDto>
    {
        public CarWorkshopDtoValidator(ICarWorkshopRepository carWorkshopRepository)
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have at least 2 characters.")
                .MaximumLength(20).WithMessage("Name should have maximum of 2 characters.")
                .Custom((value, context) =>
                {
                    var carWorkshop = carWorkshopRepository.GetByNameAsync(value).Result;
                    if(carWorkshop != null)
                    {
                        context.AddFailure($"{value} is not unique name for car workshop.");
                    }
                });

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please enter description.");

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
