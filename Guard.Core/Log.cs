﻿using Serilog;
using Serilog.Core;

namespace Guard.Core
{
    public class Log
    {
        private static Logger? log;

        public static void Init()
        {
            log = new LoggerConfiguration()
                .WriteTo.Debug()
                .WriteTo.File(
                    Path.Combine(InstallationContext.GetAppDataFolderPath(), "logs", "log.txt"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 3
                )
                .CreateLogger();
        }

        public static Logger Logger
        {
            get
            {
                if (log == null)
                {
                    throw new Exception("Logger not initialized");
                }
                return log;
            }
        }
    }
}
