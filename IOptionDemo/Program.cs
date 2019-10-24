using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOptionDemo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IOptionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                config.AddJsonFile("CustomConfig.json", optional: false, reloadOnChange: true);

                config.AddInMemoryCollection(new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Setting1","Value1"),
                    new KeyValuePair<string, string>("Setting2","Value2")
                });
                config.Build();
            })
            .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
             });
             
    }
}
