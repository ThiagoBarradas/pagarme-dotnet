using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Webhooks
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Account
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string MerchantId { get; set; }
    }
}