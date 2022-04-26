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
    public sealed class DesignationController : Base.Controller
    {
        public DesignationController(Bootstrap _) : base(_) { }

        [FunctionName("Designation_GetAllDesignation")]
        public async Task<IActionResult>GetAll(
            [HttpTrigger(AuthorizationLevel.Anonymous,"get",Route = "designation")] HttpRequest req, ILogger log)
        {
            return await Function.Execute(req, async () =>
            {
                var result = await new DesignationService().GetAllDesignation();
                return new APIResult(HttpStatusCode.OK, result, "Success");
            });
        }
    }
}
