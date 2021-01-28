using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSubscriptionCardRequest
    {
        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }
    }
}