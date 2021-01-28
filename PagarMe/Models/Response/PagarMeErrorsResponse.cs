using System.Collections.Generic;

namespace PagarMe.Models.Response
{
    public class PagarMeErrorsResponse
    {
        public IDictionary<string, string[]> Errors { get; set; }

        public string Message { get; set; }
    }
}