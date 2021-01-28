using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Charge manager
    /// </summary>
    public interface IChargeResource : IResource
    {
        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> GetCharge(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the BaseResponse<GetChargeResponse> response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> RetryCharge(string chargeId);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the BaseResponse<PagingResponse<GetChargeResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetChargeResponse>, PagarMeErrorsResponse> ListCharges(ListChargesRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="idempontencyKey">Required parameter: Idempontency Key</param>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Confirm Charge payment
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request);
       
        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, PagarMeErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request);
    }
}