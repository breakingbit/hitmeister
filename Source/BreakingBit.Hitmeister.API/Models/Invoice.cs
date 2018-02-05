using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Invoice assignment with an URL to download the Invoice
    /// </summary>
    public sealed class Invoice
    {
        /// <summary>
        /// The type of this invoice
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public InvoiceType Type { get; set; }

        /// <summary>
        /// Internal ID of Invoice, unique across all Invoices
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_invoice", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// The OrderUnit's internal identifier this Invoice belongs to
        /// </summary>
        /// <value>Unique associated OrderUnit identifier</value>
        [JsonProperty("id_order_unit", Required = Required.Always)]
        public long OrderUnitIdentifier { get; set; }

        /// <summary>
        /// The Invoice Number used to display to the customer without the need
        /// to exhibit the internal Identifier
        /// </summary>
        /// <value>Displayed identifier in the document</value>
        [JsonProperty("number", Required = Required.Always)]
        public string Number { get; set; }

        /// <summary>
        /// An URL to download the invoice as pdf.
        /// </summary>
        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }
    }
}
