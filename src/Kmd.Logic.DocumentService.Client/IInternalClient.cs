// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DocumentService.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    internal partial interface IInternalClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Uploads the single citizen document
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='configurationId'>
        /// </param>
        /// <param name='cpr'>
        /// </param>
        /// <param name='retentionPeriodInDays'>
        /// </param>
        /// <param name='documentType'>
        /// Possible values include: 'CitizenDocument',
        /// 'DigitalPostCoverLetter', 'SnailMailCoverLetter'
        /// </param>
        /// <param name='document'>
        /// </param>
        /// <param name='documentName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UploadAttachmentWithHttpMessagesAsync(System.Guid subscriptionId, string configurationId = default(string), string cpr = default(string), int? retentionPeriodInDays = default(int?), string documentType = default(string), Stream document = default(Stream), string documentName = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sends the documents to citizens
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SendCitizenDocumentResponse>> SendDocumentWithHttpMessagesAsync(System.Guid subscriptionId, SendCitizenDocumentRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets link to storage with access to upload document.
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='documentName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> StorageAccessWithHttpMessagesAsync(System.Guid subscriptionId, string documentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the upload data to db
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateDataToDbWithHttpMessagesAsync(System.Guid subscriptionId, CitizenDocumentUpdateRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the citizen document by id.
        /// </summary>
        /// <param name='documentId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetDocumentWithHttpMessagesAsync(System.Guid documentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Loads the data for Citizen Document File Access Page.
        /// </summary>
        /// <param name='documentId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CitizenDocumentFileAccessPageData>> GetFileAccessPageDataWithHttpMessagesAsync(System.Guid documentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Upload's citizen/company document for companies
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='documentConfigurationId'>
        /// </param>
        /// <param name='cvrs'>
        /// </param>
        /// <param name='document'>
        /// </param>
        /// <param name='retentionPeriodInDays'>
        /// </param>
        /// <param name='companyDocumentType'>
        /// Possible values include: 'Document', 'DigitalPostCoverLetter',
        /// 'SnailMailCoverLetter'
        /// </param>
        /// <param name='documentName'>
        /// </param>
        /// <param name='sender'>
        /// </param>
        /// <param name='documentComment'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UploadAttachmentForCompaniesWithHttpMessagesAsync(System.Guid subscriptionId, string documentConfigurationId, IList<string> cvrs, Stream document, int? retentionPeriodInDays = default(int?), string companyDocumentType = default(string), string documentName = default(string), string sender = default(string), string documentComment = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the upload data to db
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateCompanyDataToDbWithHttpMessagesAsync(System.Guid subscriptionId, CompanyDocumentRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the company document by id.
        /// </summary>
        /// <param name='documentId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GeCompanyDocumentWithHttpMessagesAsync(System.Guid documentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Loads the data for Company Document File Access Page.
        /// </summary>
        /// <param name='documentId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DocumentFileAccessPageData>> GetCompanyFileAccessPageDataWithHttpMessagesAsync(System.Guid documentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create provider config to send citizen/company document
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SaveConfigWithHttpMessagesAsync(System.Guid subscriptionId, DocumentProviderConfigRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Loads the provider config.
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<DocumentConfigResponse>>> LoadProviderConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Edit citizen document configuration settings.
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='configurationId'>
        /// configuration Id
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> EditConfigWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid configurationId, DocumentProviderConfigRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Loads all uploaded documents based on cpr number
        /// </summary>
        /// <param name='cpr'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<LoadDocumentResponse>>> GetFileAccessListByCPrWithHttpMessagesAsync(string cpr, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Loads all uploaded documents based on cvr number
        /// </summary>
        /// <param name='cvr'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<LoadDocumentResponse>>> GetFileAccessListByCvrWithHttpMessagesAsync(string cvr, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
