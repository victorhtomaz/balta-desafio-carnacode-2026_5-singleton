using Challenge.Enums;
using Challenge.Singletons;

namespace Challenge.Services;

internal class DatabaseService
{
    private readonly ConfigurationSingleton _config;
    public DatabaseService()
    {
        _config = ConfigurationSingleton.GetConfiguration();
    }
    public void Connect()
    {
        var connectionString = _config.GetSetting(SettingKey.DatabaseConnection);
        Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
    }
}
