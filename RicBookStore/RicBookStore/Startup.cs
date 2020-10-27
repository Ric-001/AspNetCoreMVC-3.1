using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RicBookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync($"Hello from my first middleware{Environment.NewLine}");
            //    await next();
            //    await context.Response.WriteAsync($"Hello from my first middleware response{Environment.NewLine}");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync($"Hello from my second middleware{Environment.NewLine}");
            //    await next();
            //    await context.Response.WriteAsync($"Hello from my second middleware response{Environment.NewLine}");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync($"Hello from my third middleware{Environment.NewLine}");
            //    await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.Map("/", async context =>
                //{
                //    if (env.IsDevelopment())
                //        await context.Response.WriteAsync($"Hello Ric World!{Environment.NewLine}The enviroment is: Dev");
                //    else if (env.IsProduction())
                //        await context.Response.WriteAsync($"Hello Ric World!{Environment.NewLine}The enviroment is:Prod");
                //    else if (env.IsStaging())
                //        await context.Response.WriteAsync($"Hello Ric World!{Environment.NewLine}The enviroment is:Stag");
                //    else if (env.IsEnvironment("Develop"))
                //        await context.Response.WriteAsync($"Hello Ric World!{Environment.NewLine}The enviroment is:custom name Develop");


                //});
                
                endpoints.MapDefaultControllerRoute();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/Ric", async context =>
                {
                    await context.Response.WriteAsync($"Hello hello Ric World!{Environment.NewLine}");
                });
            });
        }
    }
}
