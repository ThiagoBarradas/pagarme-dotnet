using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateConfirmPaymentRequest
    {
        public int? Amount { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}