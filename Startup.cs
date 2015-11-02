using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;

namespace WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello World\n");
            });
        }
        public static void Main(string[] args)
        {
            WebApplication.Run<Startup>(args);
        }
    }
}