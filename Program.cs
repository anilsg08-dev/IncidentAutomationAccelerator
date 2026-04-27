
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace IncidentAutomationAPI
{
    public class Program
    {
        /// <summary>
        /// Entry point for the Incident Automation API.
        /// Configures and runs the web host.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates and configures the host builder.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        /// <returns>IHostBuilder instance</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Use Startup.cs for service and middleware configuration
                    webBuilder.UseStartup<Startup>();
                });
    }
}
