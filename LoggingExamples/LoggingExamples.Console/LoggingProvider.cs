using Microsoft.Extensions.Logging;

namespace LoggingExamples.Console
{
    public class LoggingProvider : ILoggingService
    {
        private readonly ILogger<LoggingProvider> logger;

        public LoggingProvider(ILogger<LoggingProvider> logger)
        {
            this.logger = logger;
        }

        public void LogStuff()
        {
            PerformSampleLog();
        }

        private void PerformSampleLog()
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