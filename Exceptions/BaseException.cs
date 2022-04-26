using System;
using System.Collections.Generic;
using System.Text;
//udf
using System.Net;

namespace MyApplication.Exceptions
{
    public class BaseException : Exception
    {
        public HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        public string errorMessage;
        public Exception innerException;

        public BaseException(HttpStatusCode httpStatusCode, string message, Exception innerException) : base(message, innerException)
        {
            errorMessage = message;
            statusCode = httpStatusCode;
            this.innerException = innerException;
        }
    }


}
