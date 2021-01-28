using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPhoneResponse
    {
        public string AreaCode { get; set; }

        public string CountryCode { get; set; }

        public string Number { get; set; }
    }
}