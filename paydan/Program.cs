using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace paydan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        serverOptions.Listen(IPAddress.Any, 8000, listenOptions =>
                        {
                            listenOptions.Protocols = HttpProtocols.Http2;
                            //listenOptions.UseHttps("testCert.pfx", "testPassword");
                        });
                        serverOptions.ConfigureEndpointDefaults(lo => lo.Protocols = HttpProtocols.Http2);
                    })
                    .UseStartup<Startup>();
                });
    }
}
