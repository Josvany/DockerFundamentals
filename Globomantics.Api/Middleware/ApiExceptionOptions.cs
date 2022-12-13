using Microsoft.AspNetCore.Http;
using System;

namespace Globomantics.Api.Middleware
{
    public class ApiExceptionOptions
    {
        public Action<HttpContext, Exception, ApiError> AddResponseDetails { get; set; }
    }
}