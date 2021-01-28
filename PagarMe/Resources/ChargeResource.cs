using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using PagarMe.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class ChargeResource : BaseResource, IChargeResource
    {
        public ChargeResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> GetCharge(string chargeId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges/{chargeId}";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetChargeResponse>, PagarMeErrorsResponse> ListCharges(ListChargesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetChargeResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/charges/{chargeId}";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/capture";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/confirm-payment";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> RetryCharge(string chargeId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/retry";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/credit-card";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/due-date";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/metadata";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/payment-method";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }
    }
}