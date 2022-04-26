using System;
using System.Collections.Generic;
using System.Text;
//udf
using System.Threading.Tasks;
using MyApplication.Common.Services;
using System.Net;
using MyApplication.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace MyApplication.API
{
    public sealed class CompanyController : Base.Controller
    {
        public CompanyController(Bootstrap _) : base(_)
        {}

        [FunctionName("Company_GetAllCompany")]
        public async Task<IActionResult> GetAll(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "company")] HttpRequest req, ILogger log)
        {
            return await Function.Execute(req, async () =>
            {
                //var session = Utils.AuthUtils.ValidateJWTUser(req.Headers["token"]);
                var result = await new CompanyService().GetAllCompany();
                return new APIResult(HttpStatusCode.OK, result, "Success");
            });
        }

    }
}
