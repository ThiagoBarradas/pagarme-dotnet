using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateBankTransferPaymentRequest
    {
        public string Bank { get; set; }

        public int Retries { get; set; }
    }
}