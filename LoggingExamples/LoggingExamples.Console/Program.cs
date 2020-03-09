using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LoggingExamples.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args)
                                   .ConfigureServices((context, services) =>
                                   {
                                       services.AddTransient(typeof (ILoggingService), typeof (LoggingProvider));
                                       services.AddHostedService<LoggingExamples>();
                                   }).Build();

            host.Run();
        }
    }
}