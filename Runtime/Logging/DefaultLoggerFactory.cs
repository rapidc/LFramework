using System;
using System.Collections.Generic;

public class DefaultLoggerFactory : ILoggerFactory
{
    private readonly Dictionary<string, ILogger> loggerMap = new Dictionary<string, ILogger>();

    public ILogger GetLogger<T>()
    {
        return GetLogger(typeof(T));
    }

    public ILogger GetLogger(Type type)
    {
        return GetLogger(type.FullName);
    }

    public ILogger GetLogger(string name)
    {
        if (loggerMap.TryGetValue(name, out var logger))
        {
            return logger;
        }
        logger = new DefaultLogger(name);
        loggerMap.Add(name, logger);
        return logger;
    }
}
