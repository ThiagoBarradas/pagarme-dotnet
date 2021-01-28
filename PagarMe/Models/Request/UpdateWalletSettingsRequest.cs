using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateWalletSettingsRequest
    {
        public bool Enabled { get; set; }

        public int MaxCards { get; set; }

        public bool Shared { get; set; }
    }
}
