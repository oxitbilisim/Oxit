using System;
using FluentValidation;
using Oxit.Domain.Models;

namespace Oxit.Domain.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("dont be emptyf field");
        }
    }
}

