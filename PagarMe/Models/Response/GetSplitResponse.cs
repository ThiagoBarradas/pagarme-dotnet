using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetSplitResponse
    {
        public int Amount { get; set; }

        public string GatewayId { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        public string Type { get; set; }
    }
}