using System;
using System.Collections.Generic;
using GameWork.Core.Logging.PlatformAdaptors;

namespace GameWork.Core.Logging.Tests.MockObjects
{
    public class MockLogger : ILogger
    {
        public readonly List<LogMessage> Messages = new List<LogMessage>();

        public void Debug(string message)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Debug,
                Message = message
            });
        }

        public void Error(Exception exception)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Error,
                Exception = exception
            });
        }

        public void Error(string message)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Error,
                Message = message
            });
        }

        public void Fatal(Exception exception)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Fatal,
                Exception = exception
            });
        }

        public void Fatal(string message)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Fatal,
                Message = message
            });
        }

        public void Info(string message)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Info,
                Message = message
            });
        }

        public void Warning(string message)
        {
            Messages.Add(new LogMessage
            {
                LogLevel = LogLevel.Warning,
                Message = message
            });
        }
    }
}
