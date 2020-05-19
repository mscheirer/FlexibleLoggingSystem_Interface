using System;

namespace FlexibleLoggingSystem
{
    public class ApplicationLog
    {
        private static ILogger configuredLogger;

            private static ILogger Logger
            {
                get
                {
                    if (ApplicationLog.configuredLogger is null)
                    {
                        return new ConsoleLogger();
                    }

                    return ApplicationLog.configuredLogger;
                }
            }

        internal static void ConfigureLogger(DebugWindowLogger debugWindowLogger)
        {
            throw new NotImplementedException();
        }

        public static void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
            {
                ApplicationLog.Logger.WriteLog(level, errorMessage, additionalInfo);
            }
        }
    }