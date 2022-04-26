using Microsoft.AspNetCore.Mvc;
using MyApplication.Common.Models;
using System.Linq;

namespace MyApplication.Extensions
{
    public static class ModelExtensions
    {
        public static BadRequestObjectResult ToBadRequest<T>(this ValidatableRequest<T> request)
        {
            return new BadRequestObjectResult(request.Errors.Select(e => new
            {
                Field = e.PropertyName,
                Error = e.ErrorMessage
            }));
        }

    }
}
