using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateLocationRequest
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}