﻿namespace FlexibleLoggingSystem
{
    public class DebugWindowLogger : ILogger
    {
        public void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            System.Diagnostics.Debug.WriteLine($"{level}: {errorMessage}");

            if (!string.IsNullOrWhiteSpace(additionalInfo))
            {
                System.Diagnostics.Debug.WriteLine(additionalInfo);
            }
        }

    }
}
