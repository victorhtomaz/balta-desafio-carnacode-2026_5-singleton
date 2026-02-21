using Challenge.Enums;
using Challenge.Singletons;

namespace Challenge.Services;

internal class CacheService
{
    private readonly ConfigurationSingleton _config;

    public CacheService()
    {
        _config = ConfigurationSingleton.GetConfiguration();
    }

    public void Connect()
    {
        var cacheServer = _config.GetSetting(SettingKey.CacheServer);
        Console.WriteLine($"[CacheService] Conectando ao cache: {cacheServer}");
    }
}
