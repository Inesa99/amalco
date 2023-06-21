using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
namespace Amalco.Web.Middleware
{
    public class Test
    {
        private readonly RequestDelegate _next;
        public Test(RequestDelegate next)
        {
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context)
        {
          
            var segmentsCount = new Uri(context.Request.GetDisplayUrl()).Segments.Count();
            if (context.Request.GetDisplayUrl().EndsWith("/") && segmentsCount>1)
            {
              
               
                context.Response.Redirect(context.Request.GetDisplayUrl().TrimEnd('/'), true);
               
            }
            else
            {
                await _next.Invoke(context);
            }

        }
    }
}
