using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutPixPaymentResponse
    {
        public DateTime ExpiresAt { get; set; }
    }
}