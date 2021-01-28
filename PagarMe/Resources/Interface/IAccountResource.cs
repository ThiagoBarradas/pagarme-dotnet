using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Account manager
    /// </summary>
    public interface IAccountResource : IResource
    {
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> GetAccount(string accountId);

        /// <summary>
        /// List all accounts
        /// </summary>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetAccountResponse>, PagarMeErrorsResponse> ListAccounts();

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> CreateAccount(CreateAccountRequest request);
        
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetAccountResponse>, PagarMeErrorsResponse> GetTestAccounts(string masterAccountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request);
        
        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request);

        /// <summary>
        /// Update Status
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request);

        /// <summary>
        ///     
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateMundipaggSettingsRequest(string accountId, UpdateMundipaggSettingsRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdatePagarmeSettingsRequest(string accountId, UpdatePagarmeSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCreditCardSettings(string accountId, UpdateCreditCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateDebitCardSettings(string accountId, UpdateDebitCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateBoletoSettings(string accountId, UpdateBoletoSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateBankTransferSettings(string accountId, UpdateBankTransferSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateWalletSettings(string accountId, UpdateWalletSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSafetyPaySettings(string accountId, UpdateSafetyPaySettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateVoucherSettings(string accountId, UpdateVoucherSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateWebhookSettings(string accountId, UpdateWebhookSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAttemptSettings(string accountId, UpdateAttemptSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCheckoutSettings(string accountId, UpdateCheckoutSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateRenewCardSettings(string accountId, UpdateRenewCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSplitSettings(string accountId, UpdateSplitSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateOrderSettings(string accountId, UpdateOrderSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateSubscriptionSettings(string accountId, UpdateSubscriptionSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateNotificationSettings(string accountId, UpdateNotificationSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateGuaranteedCancellationSettings(string accountId, UpdateGuaranteedCancellationSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateCashSettings(string accountId, UpdateCashSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, PagarMeErrorsResponse> UpdateAntifraudSettings(string accountId, UpdateCashSettingsRequest request);

    }
}