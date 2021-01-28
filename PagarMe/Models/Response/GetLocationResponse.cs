using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetLocationResponse
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}