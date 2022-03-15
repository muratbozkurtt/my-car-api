using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.Infrastructure.Context
{
    public class ApplicationContext : IApplicationContext
    {
        private readonly IHttpContextAccessor _httpContext;

        public ApplicationContext(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string IpAddress
        {
            get { return _httpContext.HttpContext.Request.Headers["IpAddress"]; }
        }
    }
}
