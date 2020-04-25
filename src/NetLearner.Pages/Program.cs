using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NetLearner.Pages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // uses Generic Host in .NET Core 3.x
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}