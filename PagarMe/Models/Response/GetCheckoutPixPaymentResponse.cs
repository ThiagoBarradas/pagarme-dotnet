using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PagarMe.Models.Commons;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutPixPaymentResponse
    {
        public DateTime ExpiresAt { get; set; }
        
        public List<PixAdditionalInformation> AdditionalInformation { get; set; }
    }
}