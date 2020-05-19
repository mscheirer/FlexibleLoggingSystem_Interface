using System;

namespace FlexibleLoggingSystem
{
    public class ConsoleLogger : ILogger
    {

        public void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            Console.WriteLine($"{level}: {errorMessage}");
            
            if (!string.IsNullOrWhiteSpace(additionalInfo))
            {
                Console.WriteLine(additionalInfo);
            }
        }
    }
}
