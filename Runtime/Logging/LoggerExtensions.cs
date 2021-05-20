public static class LoggerExtensions
{
    public static void Debug(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Debug, message);
    }

    public static void DebugFormat(this ILogger logger, string format, params object[] args)
    {
        logger.Log(LogLevel.Debug, string.Format(format, args));
    }

    public static void Warning(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Warning, message);
    }

    public static void WarningFormat(this ILogger logger, string format, params object[] args)
    {
        logger.Log(LogLevel.Warning, string.Format(format, args));
    }

    public static void Error(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Error, message);
    }

    public static void ErrorFormat(this ILogger logger, string format, params object[] args)
    {
        logger.Log(LogLevel.Error, string.Format(format, args));
    }
}
