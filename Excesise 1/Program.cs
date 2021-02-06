using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ebs2
{
    public class Program
    {
        public static Dictionary<string, int> couponDictionary = new Dictionary<string, int>();
        public static void Main(string[] args)
        {
            for(var i = 0; i < 10; i++ )
            {
                var rnd = new Random();
                couponDictionary.Add(Guid.NewGuid().ToString(),
                rnd.Next());
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
