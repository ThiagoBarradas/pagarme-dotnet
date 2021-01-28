using PagarMe.Models.Enums;
using System;

namespace PagarMe.Models.Request
{

    public class ListOrdersRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public PaymentMethodTypeEnum PaymentMethod { get; set; }

        public OrderStatusEnum Status { get; set; }
    }
}