using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {

        }
    }
}
