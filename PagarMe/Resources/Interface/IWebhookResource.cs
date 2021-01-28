using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Models.Webhooks;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Webhook manager
    /// </summary>
    public interface IWebhookResource : IResource
    {
        /// <summary>
        /// Parse webhook received from PagarMe Api
        /// </summary>
        /// <param name="json">Received json</param>
        /// <returns>Webhook object</returns>
        WebhookReceived ParseWebhook(string json);

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="request">List webhooks request</param>
        /// <returns>Base response with paged webhooks data</returns>
        BaseResponse<PagingResponse<GetWebhookResponse>, PagarMeErrorsResponse> ListWebhooks(ListWebhooksRequest request);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, PagarMeErrorsResponse> GetWebhook(string webhookId);

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, PagarMeErrorsResponse> RetryWebhook(string webhookId);
    }
}