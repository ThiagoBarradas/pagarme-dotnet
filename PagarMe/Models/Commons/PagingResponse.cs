using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Commons
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PagingResponse<T>
    {
        public T[] Data { get; set; }

        public Paging Paging { get; set; }
    }
}