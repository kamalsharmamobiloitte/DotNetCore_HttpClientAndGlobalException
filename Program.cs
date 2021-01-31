using EFOperation.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging; 
using NLog.Web;


namespace EFOperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var provider = scope.ServiceProvider;
                try
                {
                    
                    var context = provider.GetRequiredService<SchoolContext>();
                    DBInitializer.Initialize(context);
                }
                catch
                {
                    var logger = provider.GetRequiredService<ILogger<Program>>();
                    logger.LogError("Unable to seed Data");
                }
                                    
            }
            host.Run(); 
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging((hostingcontext, logging) =>
            {
                logging.AddNLog(@"D:\Projects\EFOperation\nlog.config");
            })
            .ConfigureWebHostDefaults(webBuilder =>
             {
                webBuilder.UseStartup<Startup>();
             });
    }
}
