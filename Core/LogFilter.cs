using System;
using System.Text;
//UDF
using System.Collections.Generic;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace MyApplication.Core
{
    public class LogFilter : IFunctionInvocationFilter, IFunctionExceptionFilter
    {
        public Task OnExecutingAsync(FunctionExecutingContext executingContext, CancellationToken cancellationToken)
        {
            executingContext.Logger.LogInformation($"---- LOG: Executing function {executingContext.FunctionName} ----");

            return Task.CompletedTask;
        }

        public Task OnExecutedAsync(FunctionExecutedContext executedContext, CancellationToken cancellationToken)
        {
            executedContext.Logger.LogInformation($"---- LOG: Executed function {executedContext.FunctionName} ----");

            return Task.CompletedTask;
        }

        public Task OnExceptionAsync(FunctionExceptionContext exceptionContext, CancellationToken cancellationToken)
        {
            exceptionContext.Logger.LogInformation($"---- LOG: Exception in function {exceptionContext.FunctionName} ----");
            exceptionContext.Logger.LogInformation($"---- LOG: Exception : {exceptionContext.Exception.Message} ----");

            return Task.CompletedTask;
        }

    }
}
