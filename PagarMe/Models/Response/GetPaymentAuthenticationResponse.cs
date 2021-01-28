using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPaymentAuthenticationResponse
    {
        public GetThreeDSecureResponse ThreedSecure { get; set; }

        public string Type { get; set; }
    }
}