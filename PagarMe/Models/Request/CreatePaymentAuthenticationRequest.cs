using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePaymentAuthenticationRequest
    {
        public CreateThreeDSecureRequest ThreedSecure { get; set; }

        public string Type { get; set; }
    }
}