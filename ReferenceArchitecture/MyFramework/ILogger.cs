using System;
using System.Collections.Generic;
using System.Text;

namespace MyFramework
{
    public interface ILogger
    {
        void Log(string info, LogLevel logLevel);
    }

    public enum LogLevel
    {
        Information,
        Warning,
        Exception,
        Critical
    }
}
