using Microsoft.AspNetCore.Http;
using NLog;

namespace Greenbox.LineOA.Infrastructure.Log
{
    public class NLogHelper : ILogHelper
    {
        private readonly Logger _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NLogHelper(IHttpContextAccessor httpContextAccessor)
        {
            _logger = LogManager.GetLogger("mongo");
            _httpContextAccessor = httpContextAccessor;
        }

        public void Info(string message, LogEvent logEvent = LogEvent.None)
            => Log(LogLevel.Info, message, logEvent);

        public void Error(string message, LogEvent logEvent = LogEvent.None, Exception? exception = null)
            => Log(LogLevel.Error, message, logEvent, exception);

        private void Log(LogLevel level, string message, LogEvent logEvent, Exception? exception = null)
        {
            var host = _httpContextAccessor.HttpContext.Request.Host.Value;
            GlobalDiagnosticsContext.Set("collection", "Log");

            if (host.Contains("dev") || host.Contains("localhost"))
                GlobalDiagnosticsContext.Set("collection", "LogDev");

            LogEventInfo theEvent = new LogEventInfo();
            theEvent.Message = message;
            theEvent.Properties["date"] = DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss.fff");
            theEvent.Properties["event"] = logEvent.ToString();

            switch (level)
            {
                case LogLevel.Info:
                    _logger.Info(theEvent);
                    break;
                case LogLevel.Error:
                    theEvent.Exception = exception;
                    _logger.Error(theEvent);
                    break;
            }
        }
    }
}
