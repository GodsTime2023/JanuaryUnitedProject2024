using Microsoft.Extensions.Configuration;

namespace JanuaryUnitedProject2024.Config
{
    public class ReadFromJs
    {
        private IConfigurationRoot _config;
        public ReadFromJs()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("settings.json")
               .Build();

            _config = builder;
        }

        public string GetData(string key) => _config[key]!;
    }
}
