using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Validators
{
   public class DeparmentValidator : Base.Validator<Models.DepartmentModel>
    {
        public DeparmentValidator()
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
