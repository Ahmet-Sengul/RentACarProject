﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty().NotNull().WithMessage("Rent Date can not be empty and null");
            RuleFor(r => r.ReturnDate).NotNull().NotEmpty().WithMessage("Return Date can not be empty and null");
        }

    }
}