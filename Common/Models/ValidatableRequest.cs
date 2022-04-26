using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Common.Models
{

    public class BaseRequest<T>
    {
        public T Value { get; set; }

        public List<FileModel> Files { get; set; }

        public Dictionary<string, string> Filters { get; set; }

    }
   public  class ValidatableRequest<T>: BaseRequest<T>
    {
        public bool IsValid { get; set; }

        public IList<ValidationFailure> Errors { get; set; }
    }
}
