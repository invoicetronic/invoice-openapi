/*
 * Italian Invoice API
 *
 *  ## Overview  The Invoice API is a RESTful API that allows you to send and receive invoices through the Italian Servizio di Interscambio (Interchange Service).  ### Authentication  The Invoicetronic API uses API keys to authenticate requests. If you don't have any API Key, you can request one by registering with the [Invoicetronic Developer Portal][1].  Test mode secret keys have the prefix `ik_test_` and live mode secret keys have the prefix `ik_live_`. Make sure to use the correct key for each environment.  > Your API keys carry many privileges, so be sure to keep them secure! Do not share your secret API keys in publicly > accessible areas such as GitHub, client-side code, and so forth.  All API requests must be made over HTTPS. Calls made over plain HTTP will fail. API requests without authentication will also fail.  #### Basic Authentication  Basic Authentication is how you authenticate with the API. Use your API Key as the username and leave the password empty. If your client does not allow empty passwords, you can use any value as the password. Here's an example of how to authenticate with Basic Authentication and curl:  ```curl curl https://api.invoicetronic.com/invoice/v1/send \\     -u ik_test_1234567890abcdefg:  # The colon prevents curl from asking for a password. ```  [1]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: v1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Event
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="id">Unique identifier. Leave it at 0 for new records as it will be set automatically..</param>
        /// <param name="created">Creation date. It is set automatically..</param>
        /// <param name="varVersion">Row version, for optimistic concurrency. It is set automatically..</param>
        /// <param name="companyId">Company id..</param>
        /// <param name="method">Request method..</param>
        /// <param name="query">Request query..</param>
        /// <param name="endpoint">API endpoint..</param>
        /// <param name="apiVersion">Api version..</param>
        /// <param name="statusCode">Status code returned by the API..</param>
        /// <param name="dateTime">Date and time of the request..</param>
        /// <param name="error">Response error..</param>
        /// <param name="requestBody">Request payload. It is guaranteed to be cyphered at rest..</param>
        /// <param name="responseBody">Response payload. It is guaranteed to be cyphered at rest..</param>
        /// <param name="userId">User id..</param>
        /// <param name="apiKeyId">Api key id..</param>
        public Event(int id = default(int), DateTime created = default(DateTime), int varVersion = default(int), int? companyId = default(int?), string method = default(string), string query = default(string), string endpoint = default(string), int apiVersion = default(int), int statusCode = default(int), DateTime dateTime = default(DateTime), string error = default(string), string requestBody = default(string), string responseBody = default(string), int userId = default(int), int apiKeyId = default(int))
        {
            this.Id = id;
            this.Created = created;
            this.VarVersion = varVersion;
            this.CompanyId = companyId;
            this.Method = method;
            this.Query = query;
            this.Endpoint = endpoint;
            this.ApiVersion = apiVersion;
            this.StatusCode = statusCode;
            this.DateTime = dateTime;
            this.Error = error;
            this.RequestBody = requestBody;
            this.ResponseBody = responseBody;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
        }

        /// <summary>
        /// Unique identifier. Leave it at 0 for new records as it will be set automatically.
        /// </summary>
        /// <value>Unique identifier. Leave it at 0 for new records as it will be set automatically.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Creation date. It is set automatically.
        /// </summary>
        /// <value>Creation date. It is set automatically.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Row version, for optimistic concurrency. It is set automatically.
        /// </summary>
        /// <value>Row version, for optimistic concurrency. It is set automatically.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Company id.
        /// </summary>
        /// <value>Company id.</value>
        [DataMember(Name = "company_id", EmitDefaultValue = true)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Request method.
        /// </summary>
        /// <value>Request method.</value>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Request query.
        /// </summary>
        /// <value>Request query.</value>
        [DataMember(Name = "query", EmitDefaultValue = true)]
        public string Query { get; set; }

        /// <summary>
        /// API endpoint.
        /// </summary>
        /// <value>API endpoint.</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Api version.
        /// </summary>
        /// <value>Api version.</value>
        [DataMember(Name = "api_version", EmitDefaultValue = false)]
        public int ApiVersion { get; set; }

        /// <summary>
        /// Status code returned by the API.
        /// </summary>
        /// <value>Status code returned by the API.</value>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Date and time of the request.
        /// </summary>
        /// <value>Date and time of the request.</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Response error.
        /// </summary>
        /// <value>Response error.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Request payload. It is guaranteed to be cyphered at rest.
        /// </summary>
        /// <value>Request payload. It is guaranteed to be cyphered at rest.</value>
        [DataMember(Name = "request_body", EmitDefaultValue = true)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Response payload. It is guaranteed to be cyphered at rest.
        /// </summary>
        /// <value>Response payload. It is guaranteed to be cyphered at rest.</value>
        [DataMember(Name = "response_body", EmitDefaultValue = true)]
        public string ResponseBody { get; set; }

        /// <summary>
        /// Wether the request was successful.
        /// </summary>
        /// <value>Wether the request was successful.</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; private set; }

        /// <summary>
        /// Returns false as Success should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuccess()
        {
            return false;
        }
        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Api key id.
        /// </summary>
        /// <value>Api key id.</value>
        [DataMember(Name = "api_key_id", EmitDefaultValue = false)]
        public int ApiKeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ApiKeyId: ").Append(ApiKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
