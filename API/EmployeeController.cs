using System.Threading.Tasks;
using MyApplication.Common.Services;
using System.Net;
using MyApplication.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MyApplication.Common.Models;
using MyApplication.Common.Validators;

using System;
using MyApplication.Exceptions;
using System.Linq;
using MyApplication.Extensions;

namespace MyApplication.API
{
    public sealed class EmployeeController : Base.Controller
    {
        public EmployeeController(Bootstrap _) : base(_) { }

        [FunctionName("Employee_GetEmployee")]
        public async Task<IActionResult> GetAll(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "employee")] HttpRequest req, ILogger log)
        {
            return await Function.Execute(req, async () =>
            {
                var result = await new EmployeeService().GetAllEmployee();
                return new APIResult(HttpStatusCode.OK, result, "Success");
            });
        }

        //[FunctionName("Employee_CreateUpdate")]
        //public async Task<IActionResult> Create([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "employee")] HttpRequest req, ILogger log)
        //{
        //    return await Function.Execute(req, async () =>
        //    {
        //        var request = await req.Parse<EmployeeModal,EmployeeValidator>();
             
        //        if (request.IsValid)
        //        {
        //           // var session = Utils.AuthUtils.ValidateJWTUser(req.Headers["token"]);
        //            var result = await new EmployeeService().CreateUpdate(request.Value);
        //            return new APIResult(HttpStatusCode.OK, null, "Success");
        //        }
        //        else
        //        {
        //            return new APIResult(HttpStatusCode.BadRequest, request.Errors.Select(x => x.ErrorMessage).ToList(), "Validation Failed");
        //        }
        //    });
        //}
    }
}


