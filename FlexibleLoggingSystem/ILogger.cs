namespace FlexibleLoggingSystem
{
    interface ILogger
    {
       void WriteLog(LogLevel level, string errorMessage, string additionalInfo);
    }

}
