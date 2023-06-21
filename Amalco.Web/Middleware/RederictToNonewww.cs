using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amalco.Web.Middleware
{
    public class RederictToNonewww
    {
        private readonly RequestDelegate _next;
        public RederictToNonewww(RequestDelegate next)
        {
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context)
        {

            if (context.Request.Host.Value.StartsWith("www.", StringComparison.OrdinalIgnoreCase))
            {

                context.Response.Redirect(context.Request.Scheme + "://" + context.Request.Host.Host.Replace("www.", "") + context.Request.Path.ToString().TrimEnd('/'), true);
            }
            else
            {
                await _next.Invoke(context);
            }

        }
    }
}
