using System;

public static class LogManager
{
    private static readonly ILoggerFactory defaultLoggerFactory = new DefaultLoggerFactory();
    private static ILoggerFactory loggerFactory;

    public static ILoggerFactory Default { get => defaultLoggerFactory; }

    public static void Registry(ILoggerFactory factory)
    {
        if (loggerFactory != null && loggerFactory != factory)
        {
            throw new Exception("Don't register log factory many times");
        }

        loggerFactory = factory;
    }

    public static ILogger GetLogger(Type type)
    {
        if (loggerFactory != null)
        {
            return loggerFactory.GetLogger(type);
        }

        return defaultLoggerFactory.GetLogger(type);
    }

    public static ILogger GetLogger(string name)
    {
        if (loggerFactory != null)
        {
            return loggerFactory.GetLogger(name);
        }

        return defaultLoggerFactory.GetLogger(name);
    }
}
