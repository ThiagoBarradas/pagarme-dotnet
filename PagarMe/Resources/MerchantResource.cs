using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class MerchantResource : BaseResource, IMerchantResource
    {
        public MerchantResource(Configuration configuration) : base(configuration)
        {
        }

        public BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> GetMerchant(string merchantId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, null, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> CreateMerchant(CreateMerchantRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/merchants";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchantStatus(string merchantId, UpdateMerchantStatusRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/status";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchantSettings(string merchantId, UpdateMerchantSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/merchant-settings";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }
    }
}