using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PagarMe.Models.Commons;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutPixPaymentRequest
    {
        public DateTime? ExpiresAt { get; set; }
        
        public int? ExpiresIn { get; set; }
        
        public List<PixAdditionalInformation> AdditionalInformation { get; set; }
    }
}