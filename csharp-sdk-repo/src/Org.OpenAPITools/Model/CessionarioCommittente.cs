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
    /// CessionarioCommittente
    /// </summary>
    [DataContract(Name = "CessionarioCommittente")]
    public partial class CessionarioCommittente : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CessionarioCommittente" /> class.
        /// </summary>
        /// <param name="datiAnagrafici">datiAnagrafici.</param>
        /// <param name="sede">sede.</param>
        /// <param name="stabileOrganizzazione">stabileOrganizzazione.</param>
        /// <param name="rappresentanteFiscale">rappresentanteFiscale.</param>
        public CessionarioCommittente(DatiAnagraficiCessionarioCommittente datiAnagrafici = default(DatiAnagraficiCessionarioCommittente), SedeCessionarioCommittente sede = default(SedeCessionarioCommittente), StabileOrganizzazione stabileOrganizzazione = default(StabileOrganizzazione), RappresentanteFiscaleCessionarioCommittente rappresentanteFiscale = default(RappresentanteFiscaleCessionarioCommittente))
        {
            this.DatiAnagrafici = datiAnagrafici;
            this.Sede = sede;
            this.StabileOrganizzazione = stabileOrganizzazione;
            this.RappresentanteFiscale = rappresentanteFiscale;
        }

        /// <summary>
        /// Gets or Sets DatiAnagrafici
        /// </summary>
        [DataMember(Name = "dati_anagrafici", EmitDefaultValue = false)]
        public DatiAnagraficiCessionarioCommittente DatiAnagrafici { get; set; }

        /// <summary>
        /// Gets or Sets Sede
        /// </summary>
        [DataMember(Name = "sede", EmitDefaultValue = false)]
        public SedeCessionarioCommittente Sede { get; set; }

        /// <summary>
        /// Gets or Sets StabileOrganizzazione
        /// </summary>
        [DataMember(Name = "stabile_organizzazione", EmitDefaultValue = false)]
        public StabileOrganizzazione StabileOrganizzazione { get; set; }

        /// <summary>
        /// Gets or Sets RappresentanteFiscale
        /// </summary>
        [DataMember(Name = "rappresentante_fiscale", EmitDefaultValue = false)]
        public RappresentanteFiscaleCessionarioCommittente RappresentanteFiscale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CessionarioCommittente {\n");
            sb.Append("  DatiAnagrafici: ").Append(DatiAnagrafici).Append("\n");
            sb.Append("  Sede: ").Append(Sede).Append("\n");
            sb.Append("  StabileOrganizzazione: ").Append(StabileOrganizzazione).Append("\n");
            sb.Append("  RappresentanteFiscale: ").Append(RappresentanteFiscale).Append("\n");
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
