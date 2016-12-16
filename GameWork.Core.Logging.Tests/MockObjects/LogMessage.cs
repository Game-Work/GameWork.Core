using System;

namespace GameWork.Core.Logging.Tests.MockObjects
{
    public class LogMessage
    {
        public LogLevel LogLevel { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }
    }
}
