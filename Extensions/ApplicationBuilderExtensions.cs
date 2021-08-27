using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLib.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseProxy(this IApplicationBuilder app)
        {
            app.UseMiddleware<ProxyMiddleware>();
            return app;
        }
    }
}
