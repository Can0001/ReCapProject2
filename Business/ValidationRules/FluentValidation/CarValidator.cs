using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public class CarsValidator : AbstractValidator<Car>
        {
            public CarsValidator()
            {
                RuleFor(c => c.ModelYears).NotEmpty();
                RuleFor(c => c.DailyPrice).NotEmpty();
                RuleFor(c => c.DailyPrice).GreaterThan(0);
                RuleFor(c => c.Description).MinimumLength(2);
            }
        }
    }
}
