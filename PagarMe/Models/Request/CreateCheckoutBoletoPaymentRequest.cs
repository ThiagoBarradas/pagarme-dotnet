using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutBoletoPaymentRequest
    {
        public string Bank { get; set; }

        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }
    }
}