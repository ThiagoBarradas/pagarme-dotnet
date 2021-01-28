using PagarMe.Models.Enums;
using System;

namespace PagarMe.Models.Request
{
    public class ListChargesRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public string OrderId { get; set; }

        public PaymentMethodTypeEnum PaymentMethod { get; set; }

        public ChargeStatusEnum Status { get; set; }
    }
}