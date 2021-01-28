using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateTokenRequest
    {
        public CreateCardTokenRequest Card { get; set; }

        public string Type { get; set; } = "card";
    }
}