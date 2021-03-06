using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateIncrementRequest
    {
        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string IncrementType { get; set; }

        public string ItemId { get; set; }

        public double Mvalue { get; set; }
    }
}