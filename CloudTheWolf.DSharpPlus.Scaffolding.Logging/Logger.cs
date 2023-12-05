using Microsoft.Extensions.Logging;
using System;

namespace CloudTheWolf.DSharpPlus.Scaffolding.Logging
{
    /// <summary>
    /// Logger for CloudTheWolf.DSharpPlus.Scaffolding 
    /// </summary>
    public class Logger
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class. 
        /// </summary>
        /// <param name="logger">
        /// See <see cref="ILogger"/>
        /// </param>
        public Logger(ILogger<Logger> logger)
        {
            ConsoleLogger = logger;
        }

        /// <summary>
        /// Gets or sets <see cref="ILoggerFactory"/>
        /// </summary>
        public static ILoggerFactory LoggerFactory { get; set; }

        /// <summary>
        /// Gets or sets <see cref="ILogger"/>
        /// </summary>
        public static ILogger<Logger> ConsoleLogger { get; set; }


        /// <summary>
        /// Log a message as Information
        /// </summary>
        /// <param name="message">Logging Message</param>
        public static void LogInfo(string message)
        {
            ConsoleLogger.LogInformation(message);
        }

        /// <summary>
        /// Log a message as Warning
        /// </summary>
        /// <param name="message">Logging Message</param>
        public static void LogWarning(string message)
        {
            ConsoleLogger.LogWarning(message);
        }

        /// <summary>
        /// Log a message as Error and pass an <see cref="Exception"/>
        /// </summary>
        /// <param name="message">Logging Message</param>
        /// <param name="exception">Exception details</param>
        public static void LogError(string message, Exception exception)
        {
            ConsoleLogger.LogError(message, exception);
        }
    }
}
