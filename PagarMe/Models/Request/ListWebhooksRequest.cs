using PagarMe.Models.Enums;
using System;

namespace PagarMe.Models.Request
{
    public class ListWebhooksRequest : BaseListRequest
    {
        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public WebhookStatusEnum? Status { get; set; }

        public WebhookEventEnum? WebhookEvent { get; set; }
    }
}