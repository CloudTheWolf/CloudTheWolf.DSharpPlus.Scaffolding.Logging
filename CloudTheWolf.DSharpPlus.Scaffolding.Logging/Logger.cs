using Microsoft.Extensions.Logging;

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
        public static ILogger Log { get; set; }

        /// <summary>
        /// Initializes the logger.
        /// </summary>
        /// <param name="logger">
        /// See <see cref="Microsoft.Extensions.Logging.ILogger"/>
        /// </param>
        public static void Initialize(ILogger logger)
        {
            Log = logger;
        }
    }
}