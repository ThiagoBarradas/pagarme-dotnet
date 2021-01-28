using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeSplitRulesRequest
    {
        public int Amount { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }
    }
}