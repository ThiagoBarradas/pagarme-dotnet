using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using PagarMe.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class CustomerResource : BaseResource, ICustomerResource
    {
        public CustomerResource(Configuration configuration) : base(configuration) { }

        #region Customer

        public BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> GetCustomer(string customerId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetCustomerResponse>, PagarMeErrorsResponse> ListCustomers(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetCustomerResponse>>(method, endpoint, query);
        }

        public BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse, PagarMeErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/customers/{customerId}/metadata";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        #endregion

        #region Address

        public BaseResponse<GetAddressResponse, PagarMeErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/addresses";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAddressResponse, PagarMeErrorsResponse> DeleteAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<GetAddressResponse, PagarMeErrorsResponse> GetAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetAddressResponse>, PagarMeErrorsResponse> ListAddresses(ListAddressesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/addresses";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetAddressResponse>>(method, endpoint, query);
        }

        public BaseResponse<GetAddressResponse, PagarMeErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        #endregion

        #region Card

        public BaseResponse<GetCardResponse, PagarMeErrorsResponse> CreateCard(string customerId, CreateCardRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCardResponse, PagarMeErrorsResponse> GetCard(string customerId, string cardId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetCardResponse>, PagarMeErrorsResponse> ListCards(ListCardsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/cards";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetCardResponse>>(method, endpoint, query);
        }

        public BaseResponse<GetCardResponse, PagarMeErrorsResponse> DeleteCard(string customerId, string cardId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetCardResponse, PagarMeErrorsResponse> RenewCard(string customerId, string cardId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards/{cardId}/renew";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetCardResponse, PagarMeErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        #endregion

        #region Access Token

        public BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/access-tokens";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> GetAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetAccessTokenResponse>, PagarMeErrorsResponse> ListAccessTokens(ListAccessTokensRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/access-tokens";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetAccessTokenResponse>>(method, endpoint, query);
        }

        public BaseResponse<GetAccessTokenResponse, PagarMeErrorsResponse> DeleteAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetAccessTokenResponse>, PagarMeErrorsResponse> DeleteAllAccessTokens(string customerId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/";

            return this.SendRequest<PagingResponse<GetAccessTokenResponse>>(method, endpoint, null);
        }

        #endregion
    }
}