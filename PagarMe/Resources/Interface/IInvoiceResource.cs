﻿using PagarMe.Models.Commons;
using PagarMe.Models.Request;
using PagarMe.Models.Response;
using RestSharp.Easy.Models;

namespace PagarMe.Resources.Interface
{
    /// <summary>
    /// Invoice manager
    /// </summary>
    public interface IInvoiceResource : IResource
    {
        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <return>Returns BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> CreateInvoice(string subscriptionId, string cycleId);

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> GetInvoice(string invoiceId);
        
        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> CancelInvoice(string invoiceId);

        /// <summary>
        /// Lists invoices
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetInvoiceResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetInvoiceResponse>, PagarMeErrorsResponse> ListInvoices(ListInvoicesRequest request);

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status</param>
        /// <return>Returns BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> UpdateInvoiceStatus(string invoiceId, UpdateInvoiceStatusRequest request);

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <return>Returns BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse, PagarMeErrorsResponse> UpdateInvoiceMetadata(string invoiceId, UpdateMetadataRequest request);
    }
}