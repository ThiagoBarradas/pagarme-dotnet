using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class AccountResource : BaseResource, IAccountResource
    {
        public AccountResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> GetAccount(string accountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<PagingResponse<GetAccountResponse>, PagarMeErrorsResponse> ListAccounts()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<PagingResponse<GetAccountResponse>, PagarMeErrorsResponse> GetTestAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request) {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateMundipaggSettingsRequest(string accountId, UpdateMundipaggSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdatePagarmeConfig(string accountId, UpdatePagarmeSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pagarme-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCreditCardSettings(string accountId, UpdateCreditCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/credit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateDebitCardSettings(string accountId, UpdateDebitCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/debit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateBoletoSettings(string accountId, UpdateBoletoSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/boleto-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateBankTransferSettings(string accountId, UpdateBankTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/bank-transfer-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateWalletSettings(string accountId, UpdateWalletSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/wallet-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSafetyPaySettings(string accountId, UpdateSafetyPaySettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/safetypay-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateVoucherSettings(string accountId, UpdateVoucherSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/voucher-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCheckoutSettings(string accountId, UpdateCheckoutSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/checkout-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateRenewCardSettings(string accountId, UpdateRenewCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/renew-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSplitSettings(string accountId, UpdateSplitSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/split-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateOrderSettings(string accountId, UpdateOrderSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/order-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSubscriptionSettings(string accountId, UpdateSubscriptionSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/subscription-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateNotificationSettings(string accountId, UpdateNotificationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/notification-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateGuaranteedCancellationSettings(string accountId, UpdateGuaranteedCancellationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/guaranteed-cancellation-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCashSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/cash-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAntifraudSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/antifraud-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateWebhookSettings(string accountId, UpdateWebhookSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/webhook-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAttemptSettings(string accountId, UpdateAttemptSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/attempt-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdatePagarmeSettingsRequest(string accountId, UpdatePagarmeSettingsRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}