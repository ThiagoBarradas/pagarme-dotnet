using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using PagarMe.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class SubscriptionResource : BaseResource, ISubscriptionResource
    {
        public SubscriptionResource(Configuration configuration) : base(configuration) { }

        #region Subscription

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> GetSubscription(string subscriptionId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> CreateSubscription(CreateSubscriptionRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<PagingResponse<GetSubscriptionResponse>, PagarMeErrorsResponse> ListSubscriptions(ListSubscriptionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetSubscriptionResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/metadata";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/minimum_price";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/payment-method";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/start-at";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Subscription Item
        
        public BaseResponse<GetSubscriptionItemResponse, PagarMeErrorsResponse> GetSubscriptionItem(string subscriptionId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionItemResponse, PagarMeErrorsResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse, PagarMeErrorsResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{subscriptionItemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetSubscriptionItemResponse>, PagarMeErrorsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetSubscriptionItemResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionItemResponse, PagarMeErrorsResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse, PagarMeErrorsResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/cycle-end-date";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/gateway-affiliation-id";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/billing-date";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/card";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, PagarMeErrorsResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/boleto-due-days";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Discount

        public BaseResponse<GetDiscountResponse, PagarMeErrorsResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, request);
        }

        public BaseResponse<GetDiscountResponse, PagarMeErrorsResponse> GetDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<GetDiscountResponse, PagarMeErrorsResponse> DeleteDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetDiscountResponse>, PagarMeErrorsResponse> ListDiscounts(ListDiscountsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/discounts/";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetDiscountResponse>>(method, endpoint, null, query);
        }

        #endregion

        #region Increment

        public BaseResponse<GetIncrementResponse, PagarMeErrorsResponse> GetIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<GetIncrementResponse, PagarMeErrorsResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/increments";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, request);
        }

        public BaseResponse<GetIncrementResponse, PagarMeErrorsResponse> DeleteIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetIncrementResponse>, PagarMeErrorsResponse> ListIncrements(ListIncrementsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/increments/";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetIncrementResponse>>(method, endpoint, null, query);
        }

        #endregion

        #region Usage

        public BaseResponse<GetUsageResponse, PagarMeErrorsResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages";

            return this.SendRequest<GetUsageResponse>(method, endpoint, request);
        }

        public BaseResponse<GetUsagesDetailsResponse, PagarMeErrorsResponse> GetCurrentUsages(ListUsageDetailsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/usages-details/";
            var query = request.ToDictionary();

            return this.SendRequest<GetUsagesDetailsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<PagingResponse<GetUsageResponse>, PagarMeErrorsResponse> ListUsages(ListUsagesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items/{request.ItemId}/usages";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetUsageResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetUsageResponse, PagarMeErrorsResponse> DeleteUsage(string subscriptionId, string itemId, string usageId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages/{usageId}";

            return this.SendRequest<GetUsageResponse>(method, endpoint, null);
        }

        #endregion
    }
}