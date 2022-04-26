using MyApplication.Common.Services;
using MyApplication.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.API
{
    public sealed class DepartmentController : Base.Controller
    {
        public DepartmentController(Bootstrap _) : base(_)
        { }
        [FunctionName("Department_GetAllDepartment")]
        public async Task<IActionResult> GetAll(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "department")] HttpRequest req, ILogger log)
        {
            return await Function.Execute(req, async () =>
            {
                //var session = Utils.AuthUtils.ValidateJWTUser(req.Headers["token"]);
                var result = await new DepartmentService().GetAllDepartment();
                return new APIResult(HttpStatusCode.OK, result, "Success");
            });
        }
    }
}
