using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSafetyPaySettingsRequest
    {
        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }
}
