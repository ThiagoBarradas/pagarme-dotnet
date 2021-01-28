using PagarMe.Models.Request;
using PagarMe.Models.Response;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Merchant manager
    /// </summary>
    public interface IMerchantResource : IResource
    {
        /// <summary>
        /// Get merchant info
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> GetMerchant(string merchantId);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> CreateMerchant(CreateMerchantRequest request);

        /// <summary>
        /// Update a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request);

        /// <summary>
        /// Update status of a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchantStatus(string merchantId, UpdateMerchantStatusRequest request);

        /// <summary>
        /// Update settings of a Merchant
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, PagarMeErrorsResponse> UpdateMerchantSettings(string merchantId, UpdateMerchantSettingsRequest request);
    }
}