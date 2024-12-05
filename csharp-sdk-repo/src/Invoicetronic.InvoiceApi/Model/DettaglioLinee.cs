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
using OpenAPIDateConverter = Invoicetronic.InvoiceApi.Client.OpenAPIDateConverter;

namespace Invoicetronic.InvoiceApi.Model
{
    /// <summary>
    /// DettaglioLinee
    /// </summary>
    [DataContract(Name = "DettaglioLinee")]
    public partial class DettaglioLinee : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DettaglioLinee" /> class.
        /// </summary>
        /// <param name="numeroLinea">numeroLinea.</param>
        /// <param name="tipoCessionePrestazione">tipoCessionePrestazione.</param>
        /// <param name="codiceArticolo">codiceArticolo.</param>
        /// <param name="descrizione">descrizione.</param>
        /// <param name="quantita">quantita.</param>
        /// <param name="unitaMisura">unitaMisura.</param>
        /// <param name="dataInizioPeriodo">dataInizioPeriodo.</param>
        /// <param name="dataFinePeriodo">dataFinePeriodo.</param>
        /// <param name="prezzoUnitario">prezzoUnitario.</param>
        /// <param name="scontoMaggiorazione">scontoMaggiorazione.</param>
        /// <param name="prezzoTotale">prezzoTotale.</param>
        /// <param name="aliquotaIva">aliquotaIva.</param>
        /// <param name="ritenuta">ritenuta.</param>
        /// <param name="natura">natura.</param>
        /// <param name="riferimentoAmministrazione">riferimentoAmministrazione.</param>
        /// <param name="altriDatiGestionali">altriDatiGestionali.</param>
        public DettaglioLinee(int numeroLinea = default(int), string tipoCessionePrestazione = default(string), List<CodiceArticolo> codiceArticolo = default(List<CodiceArticolo>), string descrizione = default(string), double? quantita = default(double?), string unitaMisura = default(string), DateTime? dataInizioPeriodo = default(DateTime?), DateTime? dataFinePeriodo = default(DateTime?), double prezzoUnitario = default(double), List<ScontoMaggiorazione> scontoMaggiorazione = default(List<ScontoMaggiorazione>), double prezzoTotale = default(double), double aliquotaIva = default(double), string ritenuta = default(string), string natura = default(string), string riferimentoAmministrazione = default(string), List<AltriDatiGestionali> altriDatiGestionali = default(List<AltriDatiGestionali>))
        {
            this.NumeroLinea = numeroLinea;
            this.TipoCessionePrestazione = tipoCessionePrestazione;
            this.CodiceArticolo = codiceArticolo;
            this.Descrizione = descrizione;
            this.Quantita = quantita;
            this.UnitaMisura = unitaMisura;
            this.DataInizioPeriodo = dataInizioPeriodo;
            this.DataFinePeriodo = dataFinePeriodo;
            this.PrezzoUnitario = prezzoUnitario;
            this.ScontoMaggiorazione = scontoMaggiorazione;
            this.PrezzoTotale = prezzoTotale;
            this.AliquotaIva = aliquotaIva;
            this.Ritenuta = ritenuta;
            this.Natura = natura;
            this.RiferimentoAmministrazione = riferimentoAmministrazione;
            this.AltriDatiGestionali = altriDatiGestionali;
        }

        /// <summary>
        /// Gets or Sets NumeroLinea
        /// </summary>
        [DataMember(Name = "numero_linea", EmitDefaultValue = false)]
        public int NumeroLinea { get; set; }

        /// <summary>
        /// Gets or Sets TipoCessionePrestazione
        /// </summary>
        [DataMember(Name = "tipo_cessione_prestazione", EmitDefaultValue = true)]
        public string TipoCessionePrestazione { get; set; }

        /// <summary>
        /// Gets or Sets CodiceArticolo
        /// </summary>
        [DataMember(Name = "codice_articolo", EmitDefaultValue = true)]
        public List<CodiceArticolo> CodiceArticolo { get; set; }

        /// <summary>
        /// Gets or Sets Descrizione
        /// </summary>
        [DataMember(Name = "descrizione", EmitDefaultValue = true)]
        public string Descrizione { get; set; }

        /// <summary>
        /// Gets or Sets Quantita
        /// </summary>
        [DataMember(Name = "quantita", EmitDefaultValue = true)]
        public double? Quantita { get; set; }

        /// <summary>
        /// Gets or Sets UnitaMisura
        /// </summary>
        [DataMember(Name = "unita_misura", EmitDefaultValue = true)]
        public string UnitaMisura { get; set; }

        /// <summary>
        /// Gets or Sets DataInizioPeriodo
        /// </summary>
        [DataMember(Name = "data_inizio_periodo", EmitDefaultValue = true)]
        public DateTime? DataInizioPeriodo { get; set; }

        /// <summary>
        /// Gets or Sets DataFinePeriodo
        /// </summary>
        [DataMember(Name = "data_fine_periodo", EmitDefaultValue = true)]
        public DateTime? DataFinePeriodo { get; set; }

        /// <summary>
        /// Gets or Sets PrezzoUnitario
        /// </summary>
        [DataMember(Name = "prezzo_unitario", EmitDefaultValue = false)]
        public double PrezzoUnitario { get; set; }

        /// <summary>
        /// Gets or Sets ScontoMaggiorazione
        /// </summary>
        [DataMember(Name = "sconto_maggiorazione", EmitDefaultValue = true)]
        public List<ScontoMaggiorazione> ScontoMaggiorazione { get; set; }

        /// <summary>
        /// Gets or Sets PrezzoTotale
        /// </summary>
        [DataMember(Name = "prezzo_totale", EmitDefaultValue = false)]
        public double PrezzoTotale { get; set; }

        /// <summary>
        /// Gets or Sets AliquotaIva
        /// </summary>
        [DataMember(Name = "aliquota_iva", EmitDefaultValue = false)]
        public double AliquotaIva { get; set; }

        /// <summary>
        /// Gets or Sets Ritenuta
        /// </summary>
        [DataMember(Name = "ritenuta", EmitDefaultValue = true)]
        public string Ritenuta { get; set; }

        /// <summary>
        /// Gets or Sets Natura
        /// </summary>
        [DataMember(Name = "natura", EmitDefaultValue = true)]
        public string Natura { get; set; }

        /// <summary>
        /// Gets or Sets RiferimentoAmministrazione
        /// </summary>
        [DataMember(Name = "riferimento_amministrazione", EmitDefaultValue = true)]
        public string RiferimentoAmministrazione { get; set; }

        /// <summary>
        /// Gets or Sets AltriDatiGestionali
        /// </summary>
        [DataMember(Name = "altri_dati_gestionali", EmitDefaultValue = true)]
        public List<AltriDatiGestionali> AltriDatiGestionali { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DettaglioLinee {\n");
            sb.Append("  NumeroLinea: ").Append(NumeroLinea).Append("\n");
            sb.Append("  TipoCessionePrestazione: ").Append(TipoCessionePrestazione).Append("\n");
            sb.Append("  CodiceArticolo: ").Append(CodiceArticolo).Append("\n");
            sb.Append("  Descrizione: ").Append(Descrizione).Append("\n");
            sb.Append("  Quantita: ").Append(Quantita).Append("\n");
            sb.Append("  UnitaMisura: ").Append(UnitaMisura).Append("\n");
            sb.Append("  DataInizioPeriodo: ").Append(DataInizioPeriodo).Append("\n");
            sb.Append("  DataFinePeriodo: ").Append(DataFinePeriodo).Append("\n");
            sb.Append("  PrezzoUnitario: ").Append(PrezzoUnitario).Append("\n");
            sb.Append("  ScontoMaggiorazione: ").Append(ScontoMaggiorazione).Append("\n");
            sb.Append("  PrezzoTotale: ").Append(PrezzoTotale).Append("\n");
            sb.Append("  AliquotaIva: ").Append(AliquotaIva).Append("\n");
            sb.Append("  Ritenuta: ").Append(Ritenuta).Append("\n");
            sb.Append("  Natura: ").Append(Natura).Append("\n");
            sb.Append("  RiferimentoAmministrazione: ").Append(RiferimentoAmministrazione).Append("\n");
            sb.Append("  AltriDatiGestionali: ").Append(AltriDatiGestionali).Append("\n");
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
