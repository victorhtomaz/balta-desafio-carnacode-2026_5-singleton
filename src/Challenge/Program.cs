using Challenge.Enums;
using Challenge.Services;
using Challenge.Singletons;

Console.WriteLine("=== Sistema de Configurações ===\n");

Console.WriteLine("Inicializando serviços...\n");

var dbService = new DatabaseService();
var apiService = new ApiService();
var cacheService = new CacheService();
var logService = new LoggingService();

Console.WriteLine("\nUsando os serviços...\n");

dbService.Connect();
apiService.MakeRequest();
cacheService.Connect();
logService.Log("Sistema iniciado");

var configuration1 = ConfigurationSingleton.GetConfiguration();

Console.WriteLine("\nCarregando configurações 1\n");
configuration1.LoadConfigurations();
configuration1.UpdateSetting(SettingKey.LogLevel, "Debug");

var configuration2 = ConfigurationSingleton.GetConfiguration();

Console.WriteLine("\nCarregando configurações 2\n");
configuration2.LoadConfigurations();

Console.WriteLine("\nVerificando se as configurações são as mesmas instâncias...\n");
Console.WriteLine("Config 1 " + configuration1.GetSetting(SettingKey.LogLevel));
Console.WriteLine("Config 2 " + configuration2.GetSetting(SettingKey.LogLevel));
