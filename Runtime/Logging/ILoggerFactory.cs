using System;

public interface ILoggerFactory
{
    ILogger GetLogger<T>();
    ILogger GetLogger(Type type);
    ILogger GetLogger(string name);
}
