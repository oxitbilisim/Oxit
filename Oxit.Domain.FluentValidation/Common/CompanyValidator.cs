using System;
using FluentValidation;
using Oxit.Domain.Models;

namespace Oxit.Domain.FluentValidation.Common
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("name not be empty please fill this field .");
        }
    }
}

