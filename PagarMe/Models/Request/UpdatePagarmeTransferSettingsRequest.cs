using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdatePagarmeTransferSettingsRequest
    {
        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }

        public int? TransferDay { get; set; }
    }
}
