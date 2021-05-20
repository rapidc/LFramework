using UnityEngine;

public class DefaultLogger : ILogger
{
    private readonly string name;

    public DefaultLogger(string name)
    {
        this.name = name;
    }

    public void Log(LogLevel logLevel, string message)
    {
        message = string.Format("[{0}]  {1}", this.name, message);

        switch (logLevel)
        {
            case LogLevel.Trace:
                Debug.Log(message);
                break;
            case LogLevel.Debug:
                Debug.Log(message);
                break;
            case LogLevel.Info:
                Debug.Log(message);
                break;
            case LogLevel.Warning:
                Debug.LogWarning(message);
                break;
            case LogLevel.Error:
                Debug.LogError(message);
                break;
            case LogLevel.Critical:
                Debug.LogError(message);
                break;
            case LogLevel.None:
                break;
        }
    }
}
