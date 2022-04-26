using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Validators
{
     public class DesignationValidator : Base.Validator<Models.DesignationModal>
    {
        public DesignationValidator()
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
