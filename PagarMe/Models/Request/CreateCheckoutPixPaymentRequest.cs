using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutPixPaymentRequest
    {
        public DateTime ExpiresAt { get; set; }
    }
}