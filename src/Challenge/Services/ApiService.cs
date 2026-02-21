using Challenge.Enums;
using Challenge.Singletons;

namespace Challenge.Services;

internal class ApiService
{
    private readonly ConfigurationSingleton _config;

    public ApiService()
    {
        _config = ConfigurationSingleton.GetConfiguration();
    }

    public void MakeRequest()
    {
        var apiKey = _config.GetSetting(SettingKey.ApiKey);
        Console.WriteLine($"[ApiService] Fazendo requisição com API Key: {apiKey}");
    }
}
