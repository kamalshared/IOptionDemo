using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IOptionDemo
{
    
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //1. The AddControllers() extension method now does exactly that -it adds the services required to use Web API Controllers, and nothing more.So you get Authorization, Validation, formatters, and CORS
            services.AddControllers(configure =>
            {
                configure.RespectBrowserAcceptHeader = true;
               // configure.ReturnHttpNotAcceptable = true;
                configure.InputFormatters
                .Add(new XmlSerializerInputFormatter(configure));
                configure.OutputFormatters.Add(new XmlSerializerOutputFormatter());
                ;
            });
            //2. this adds the MVC Controller services that are common to both Web API and MVC, but also adds the services required for rendering Razor views.
                     // services.AddControllersWithViews();
            //3. it does not add the services required for using standard MVC controllers with Razor Views.
                    //services.AddRazorPages();
            //4.If you want to use both MVC and Razor Pages in your app, you should continue to use the AddMvc() extension method.
                    //services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCustomFunctionality();


            //The main difference compared to ASP.NET Core 2.x apps is the conspicuous use of endpoint routing. 
            //An endpoint consists of a path pattern, and something to execute when called.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapDefaultControllerRoute();
                //endpoints.MapRazorPages();
                
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
