using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FirstCoreMVCBookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();  //This is used to MVC feature to the application.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();               
            });


            //else if (env.IsProduction())
            // {
            //     await context.Response.WriteAsync("Hello from prod");
            // }
            //else if (env.IsStaging())
            // {
            //     await context.Response.WriteAsync("Hello from staging");
            // }
            // else if (env.IsEnvironment("CustomENV"))
            // {
            //     await context.Response.WriteAsync("Hello from custom env");
            // }
            //Start Custom middleware using app.Use() 

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello First middleware");
            //    await next();   //This method is used to call next middleware.
            //    await context.Response.WriteAsync("Hello First middleware from response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from second middleware");

            //});

            //End Custom middleware using app.Use()



            //app.UseEndpoints(endpoints =>       //This is the default routing method. We don't have any page after "/", so it will return for default url. 
            //{                                   //We can customize by "/test". So it will show "Hello World" in "localhost:123/test" url
            //    //endpoints.MapGet("/", async context =>
            //    //{
            //    //    await context.Response.WriteAsync("hello world!");
            //    //});

            //    endpoints.MapDefaultControllerRoute();  //This method will route to Home->Index Method by default. Check definition.
            //});
        }
    }
}
