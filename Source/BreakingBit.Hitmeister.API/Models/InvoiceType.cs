using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The type of invoice, includes who was charged.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceType
    {
        /// <summary>
        /// Invoice for the seller (ie. fee charges)
        /// </summary>
        [EnumMember(Value = "invoice_seller")]
        InvoiceSeller,

        /// <summary>
        /// Invoice for a credit given to the seller
        /// </summary>
        [EnumMember(Value = "credit_seller")]
        CreditSeller,

        /// <summary>
        /// Invoice for the buyer, primarily the bill
        /// </summary>
        [EnumMember(Value = "invoice_buyer")]
        InvoiceBuyer,

        /// <summary>
        /// Invoice for a credit given to the buyer (ie. refund)
        /// </summary>
        [EnumMember(Value = "credit_buyer")]
        CreditBuyer
    }
}
