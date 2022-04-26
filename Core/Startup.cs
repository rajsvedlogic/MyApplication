using System;
using System.Collections.Generic;
using System.Text;
//UDF
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;

[assembly: FunctionsStartup(typeof(MyApplication.Core.Startup))]

namespace MyApplication.Core
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            builder.Services.AddSingleton<Bootstrap>();
           // builder.Services.AddSingleton<IFunctionFilter, LogFilter>();
            builder.Services.AddLogging();

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            });

        }
    }
}
