using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Sinks.SystemConsole.Themes;

namespace CloudTheWolf.DSharpPlus.Scaffolding.Logging
{
    /// <summary>
    /// Logger for CloudTheWolf.DSharpPlus.Scaffolding 
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Gets or sets <see cref="Microsoft.Extensions.Logging.ILogger"/>
        /// </summary>
        public static Microsoft.Extensions.Logging.ILogger Log { get; set; }

        /// <summary>
        /// Initializes the logger with Serilog.
        /// </summary>
        public static void Initialize()
        {
            var serilogLogger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate:
                    "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}", theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            Log = new SerilogLoggerFactory(serilogLogger).CreateLogger("CloudTheWolf.DSharpPlus.Scaffolding");
        }
    }
}