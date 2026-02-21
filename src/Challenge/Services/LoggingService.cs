using Challenge.Enums;
using Challenge.Singletons;

namespace Challenge.Services;

internal class LoggingService
{
    private readonly ConfigurationSingleton _config;

    public LoggingService()
    {
        _config = ConfigurationSingleton.GetConfiguration();
    }

    public void Log(string message)
    {
        var logLevel = _config.GetSetting(SettingKey.LogLevel);
        Console.WriteLine($"[LoggingService] [{logLevel}] {message}");
    }
}
