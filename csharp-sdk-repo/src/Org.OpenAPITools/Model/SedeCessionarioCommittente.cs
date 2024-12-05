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
    /// SedeCessionarioCommittente
    /// </summary>
    [DataContract(Name = "SedeCessionarioCommittente")]
    public partial class SedeCessionarioCommittente : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SedeCessionarioCommittente" /> class.
        /// </summary>
        /// <param name="indirizzo">indirizzo.</param>
        /// <param name="numeroCivico">numeroCivico.</param>
        /// <param name="cap">cap.</param>
        /// <param name="comune">comune.</param>
        /// <param name="provincia">provincia.</param>
        /// <param name="nazione">nazione (default to &quot;IT&quot;).</param>
        public SedeCessionarioCommittente(string indirizzo = default(string), string numeroCivico = default(string), string cap = default(string), string comune = default(string), string provincia = default(string), string nazione = @"IT")
        {
            this.Indirizzo = indirizzo;
            this.NumeroCivico = numeroCivico;
            this.Cap = cap;
            this.Comune = comune;
            this.Provincia = provincia;
            // use default value if no "nazione" provided
            this.Nazione = nazione ?? @"IT";
        }

        /// <summary>
        /// Gets or Sets Indirizzo
        /// </summary>
        [DataMember(Name = "indirizzo", EmitDefaultValue = true)]
        public string Indirizzo { get; set; }

        /// <summary>
        /// Gets or Sets NumeroCivico
        /// </summary>
        [DataMember(Name = "numero_civico", EmitDefaultValue = true)]
        public string NumeroCivico { get; set; }

        /// <summary>
        /// Gets or Sets Cap
        /// </summary>
        [DataMember(Name = "cap", EmitDefaultValue = true)]
        public string Cap { get; set; }

        /// <summary>
        /// Gets or Sets Comune
        /// </summary>
        [DataMember(Name = "comune", EmitDefaultValue = true)]
        public string Comune { get; set; }

        /// <summary>
        /// Gets or Sets Provincia
        /// </summary>
        [DataMember(Name = "provincia", EmitDefaultValue = true)]
        public string Provincia { get; set; }

        /// <summary>
        /// Gets or Sets Nazione
        /// </summary>
        [DataMember(Name = "nazione", EmitDefaultValue = true)]
        public string Nazione { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SedeCessionarioCommittente {\n");
            sb.Append("  Indirizzo: ").Append(Indirizzo).Append("\n");
            sb.Append("  NumeroCivico: ").Append(NumeroCivico).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Comune: ").Append(Comune).Append("\n");
            sb.Append("  Provincia: ").Append(Provincia).Append("\n");
            sb.Append("  Nazione: ").Append(Nazione).Append("\n");
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
