using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutPaymentRequest
    {
        public object AcceptedMultiPaymentMethods { get; set; }

        public List<string> AcceptedPaymentMethods { get; set; }
        
        public List<string> AcceptedBrands { get; set; }

        public CreateCheckoutBankTransferRequest BankTransfer { get; set; }

        public CreateAddressRequest BillingAddress { get; set; }

        public bool BillingAddressEditable { get; set; }

        public CreateCheckoutBoletoPaymentRequest Boleto { get; set; }

        public CreateCheckoutCreditCardPaymentRequest CreditCard { get; set; }
        
        public CreateCheckoutVoucherPaymentRequest Voucher { get; set; }

        public bool? CustomerEditable { get; set; }

        public CreateCheckoutDebitCardPaymentRequest DebitCard { get; set; }
        
        public CreateCheckoutPixPaymentRequest Pix { get; set; }

        public string DefaultPaymentMethod { get; set; }

        public int? ExpiresIn { get; set; }

        public string GatewayAffiliationId { get; set; }

        public bool SkipCheckoutSuccessPage { get; set; }

        public string SuccessUrl { get; set; }
    }
}