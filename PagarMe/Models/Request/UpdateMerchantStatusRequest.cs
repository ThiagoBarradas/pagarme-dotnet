﻿using PagarMe.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateMerchantStatusRequest
    {
        public MerchantStatusEnum Status { get; set; }
    }
}