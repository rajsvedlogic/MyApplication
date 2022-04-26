using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Validators
{
    public class CompanyValidator : Base.Validator<Models.CompanyModel>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
