using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Validators
{
    public class EmployeeValidator : Base.Validator<Models.EmployeeModal>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
