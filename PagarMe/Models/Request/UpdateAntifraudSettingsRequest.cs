using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateAntifraudSettingsRequest
    {
        public bool AutoCancel { get; set; }

        public bool AutoCapture { get; set; }
    }
}
