using Microsoft.Extensions.Configuration;

namespace Niputi.Configuration.Json
{
    class JsonConfigurationSource : IConfigurationSource
    {
        /// <summary>
        /// The Json string
        /// </summary>
        public string JsonString { get; set; }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new JsonConfigurationProvider(JsonString);
        }
    }
}
