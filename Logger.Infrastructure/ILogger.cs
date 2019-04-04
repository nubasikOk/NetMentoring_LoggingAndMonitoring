using System;

namespace Logger.Infrastructure
{
    public interface ILogger
    {
        void LogError(Exception exception, string message);

        void LogInfo(string message);

        void LogDebug(string message);
    }
}
