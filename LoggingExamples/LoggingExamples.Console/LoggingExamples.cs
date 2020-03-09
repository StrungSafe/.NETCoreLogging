using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LoggingExamples.Console
{
    public class LoggingExamples : IHostedService
    {
        private readonly ILogger<LoggingExamples> logger;

        private readonly ILoggingService loggingService;

        public LoggingExamples(ILogger<LoggingExamples> logger, ILoggingService loggingService)
        {
            this.logger = logger;
            this.loggingService = loggingService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            PerformSampleLog1();
            PerformSampleLog2();

            loggingService.LogStuff();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            PerformSampleLog1();
            PerformSampleLog2();

            loggingService.LogStuff();

            return Task.CompletedTask;
        }

        private void PerformSampleLog1()
        {
            logger.LogTrace("A trace msg");
            logger.LogDebug("A debug msg");
            logger.LogInformation("A info msg");
            logger.LogWarning("A warning msg");
            logger.LogError("A error msg");
            logger.LogCritical("A critical msg");
        }

        private void PerformSampleLog2()
        {
            logger.LogTrace("A trace msg");
            logger.LogDebug("A debug msg");
            logger.LogInformation("A info msg");
            logger.LogWarning("A warning msg");
            logger.LogError("A error msg");
            logger.LogCritical("A critical msg");
        }
    }
}