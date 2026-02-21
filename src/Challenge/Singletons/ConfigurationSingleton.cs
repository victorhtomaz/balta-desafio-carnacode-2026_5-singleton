using Challenge.Enums;

namespace Challenge.Singletons;

internal class ConfigurationSingleton
{
    private static readonly Lazy<ConfigurationSingleton> _instance = new(() => new ConfigurationSingleton());
    
    private readonly Dictionary<SettingKey, string> _settings;
    private bool _isLoaded;
    private ConfigurationSingleton() 
    {
        _settings = [];
        _isLoaded = false;
        Console.WriteLine("⚠️ Nova instância de ConfigurationManager criada!");
    }
    public void LoadConfigurations()
    {
        if (_isLoaded)
        {
            Console.WriteLine("Configurações já carregadas.");
            return;
        }

        Console.WriteLine("🔄 Carregando configurações...");

        // Simulando operação custosa de carregamento
        System.Threading.Thread.Sleep(200);

        // Carregando configurações de diferentes fontes
        _settings[SettingKey.DatabaseConnection] = "Server=localhost;Database=MyApp;";
        _settings[SettingKey.ApiKey] = "abc123xyz789";
        _settings[SettingKey.CacheServer] = "redis://localhost:6379";
        _settings[SettingKey.MaxRetries] = "3";
        _settings[SettingKey.TimeoutSeconds] = "30";
        _settings[SettingKey.EnableLogging] = "true";
        _settings[SettingKey.LogLevel] = "Information";

        _isLoaded = true;
        Console.WriteLine("✅ Configurações carregadas com sucesso!\n");
    }

    public string GetSetting(SettingKey key)
    {
        if (!_isLoaded)
            LoadConfigurations();

        if (_settings.ContainsKey(key))
            return _settings[key];

        return string.Empty;
    }
    public void UpdateSetting(SettingKey key, string value)
    {
        _settings[key] = value;
        Console.WriteLine($"Configuração atualizada: {key} = {value}");
    }

    public static ConfigurationSingleton GetConfiguration() => _instance.Value;
}
