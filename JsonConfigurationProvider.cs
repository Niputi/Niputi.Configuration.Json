using Microsoft.Extensions.Configuration;

namespace Niputi.Configuration.Json
{
    class JsonConfigurationProvider : ConfigurationProvider
    {
        public JsonConfigurationProvider(string jsonString)
        {
            JsonString = jsonString;
        }

        public string JsonString { get; }

        public override void Load()
        {
            Data = JsonConfigurationParser.Parse(JsonString);
        }
    }
}
