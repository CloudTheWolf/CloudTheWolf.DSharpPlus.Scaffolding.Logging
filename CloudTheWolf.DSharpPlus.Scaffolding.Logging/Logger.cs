using System;
using Serilog;

namespace CloudTheWolf.DSharpPlus.Scaffolding.Logging
{
    /// <summary>
    /// Logger for CloudTheWolf.DSharpPlus.Scaffolding 
    /// </summary>
    public class Logger
    {

        /// <summary>
        /// Gets or sets <see cref="Microsoft.Extensions.Logging.ILogger"/>
        /// </summary>
        public static ILogger Log { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class. 
        /// </summary>
        /// <param name="logger">
        /// See <see cref="Microsoft.Extensions.Logging.ILogger"/>
        /// </param>
        public Logger(ILogger logger)
        {
            Log = logger;
        }
    }
}