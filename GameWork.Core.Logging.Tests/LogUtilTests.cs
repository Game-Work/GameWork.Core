using System;
using System.Linq;
using GameWork.Core.Logging.Tests.MockObjects;
using NUnit.Framework;

namespace GameWork.Core.Logging.Tests
{
    public class LogUtilTests
    {
        [Test]
        public void LogsInfo()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Info;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Info));
        }

        [Test]
        public void LogsDebug()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Debug;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Debug));
        }

        [Test]
        public void LogsWarning()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Warning;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Warning));
        }

        [Test]
        public void LogsErrorMessage()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Error;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Error));
            Assert.True(logger.Messages.Any(m => m.Message != null));
        }

        [Test]
        public void LogsErrorException()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Error;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Error));
            Assert.True(logger.Messages.Any(m => m.Exception != null));
        }

        [Test]
        public void LogsFatalMessage()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Fatal;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Fatal));
            Assert.True(logger.Messages.Any(m => m.Message != null));
        }

        [Test]
        public void LogsFatalException()
        {
            // Arrange
            var logger = new MockLogger();
            LogUtil.SetLogger(logger);
            LogUtil.LogLevel = LogLevel.Fatal;

            // Act
            LogAll();

            // Assert
            Assert.True(logger.Messages.All(m => m.LogLevel <= LogLevel.Fatal));
            Assert.True(logger.Messages.Any(m => m.Exception != null));
        }

        private void LogAll()
        {
            LogUtil.Info("info");
            LogUtil.Debug("debug");
            LogUtil.Warning("warning");
            LogUtil.Error("error");
            LogUtil.Error(new Exception("error"));
            LogUtil.Fatal("fatal");
            LogUtil.Fatal(new Exception("fatal"));
        }
    }
}
