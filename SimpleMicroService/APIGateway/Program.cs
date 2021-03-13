using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                   // var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureAppConfiguration(config =>
                    //    config.AddJsonFile($"ocelot.{env}.json"));
                })
            .ConfigureAppConfiguration((hostContext, config) =>
            {
                var env = Environment.GetEnvironmentVariable("GATEWAY_ENVIRONMENT");
                config
                    .SetBasePath(hostContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile($"ocelot.{env}.json", optional: false, reloadOnChange: true);
            })
            .ConfigureLogging(logging => logging.AddConsole());  
    }
}
