using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using PagarMe.Resources.Interface;
using PagarMe.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace PagarMe.Resources
{
    public class InvoiceResource : BaseResource, IInvoiceResource
    {
        public InvoiceResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> CancelInvoice(string invoiceId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/invoices/{invoiceId}";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> CreateInvoice(string subscriptionId, string cycleId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/cycles/{cycleId}/pay";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> GetInvoice(string invoiceId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices/{invoiceId}";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetInvoiceResponse>, PagarMeErrorsResponse> ListInvoices(ListInvoicesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetInvoiceResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> UpdateInvoiceMetadata(string invoiceId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/metadata";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }

        public BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> UpdateInvoiceStatus(string invoiceId, UpdateInvoiceStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/status";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }
    }
}