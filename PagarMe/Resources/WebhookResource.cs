using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Models.Webhooks;
using PagarMe.Resources.Interface;
using PagarMe.Utils;
using Newtonsoft.Json;
using RestSharp.Easy.Models;
using System;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class WebhookResource : BaseResource, IWebhookResource
    {
        public WebhookResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetWebhookResponse, PagarMeErrorsResponse> GetWebhook(string webhookId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/hooks/{webhookId}";

            return this.SendRequest<GetWebhookResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetWebhookResponse>, PagarMeErrorsResponse> ListWebhooks(ListWebhooksRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/hooks";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetWebhookResponse>>(method, endpoint, null, query);
        }
        
        public WebhookReceived ParseWebhook(string json)
        {
            if (string.IsNullOrWhiteSpace(json) == true)
                throw new NullReferenceException($"{nameof(json)} can not be null or empty");

            return JsonConvert.DeserializeObject<WebhookReceived>(json, JsonSerializerUtil.SnakeCaseSettings);
        }

        public BaseResponse<GetWebhookResponse, PagarMeErrorsResponse> RetryWebhook(string webhookId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/hooks/{webhookId}/retry";

            return this.SendRequest<GetWebhookResponse>(method, endpoint, null);
        }
    }
}