using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public interface ICustomerResource : IResource
    {
        #region Customer

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> CreateCustomer(CreateCustomerRequest request);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> GetCustomer(string customerId);

        /// <summary>
        /// Lists all Customers
        /// </summary>
        /// <return>Returns PagingResponse of Models.GetCustomerResponse</Models.ListCustomersResponse> response from the API call</return>
        BaseResponse<PagingResponse<GetCustomerResponse>, PagarMeErrorsResponse> ListCustomers(ListCustomersRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request);

        #endregion

        #region Address

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, PagarMeErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, PagarMeErrorsResponse> GetAddress(string customerId, string addressId);

        /// <summary>
        /// Lists all adressess from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetAddressResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetAddressResponse>, PagarMeErrorsResponse> ListAddresses(ListAddressesRequest request);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, PagarMeErrorsResponse> DeleteAddress(string customerId, string addressId);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, PagarMeErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request);

        #endregion

        #region Card

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, PagarMeErrorsResponse> CreateCard(string customerId, CreateCardRequest request);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, PagarMeErrorsResponse> GetCard(string customerId, string cardId);

        /// <summary>
        /// Lists all cards from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetCardResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetCardResponse>, PagarMeErrorsResponse> ListCards(ListCardsRequest request);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, PagarMeErrorsResponse> RenewCard(string customerId, string cardId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, PagarMeErrorsResponse> DeleteCard(string customerId, string cardId);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, PagarMeErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request);

        #endregion

        #region Access Token

        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> GetAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Lists all access tokens from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetAccessTokenResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetAccessTokenResponse>, PagarMeErrorsResponse> ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> DeleteAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns BaseResponse<PagingResponse<GetAccessTokenResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetAccessTokenResponse>, PagarMeErrorsResponse> DeleteAllAccessTokens(string customerId);

        #endregion
    }
}