using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The current status of an OrderUnit, mainly paid and shipment status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderUnitStatus
    {
        /// <summary>
        /// The product was bought but not shipped yet.
        /// </summary>
        [EnumMember(Value = "need_to_be_sent")]
        NeedToBeSent,

        /// <summary>
        /// The product was sent to the customer.
        /// </summary>
        [EnumMember(Value = "sent")]
        Sent,

        /// <summary>
        /// The customer received the product.
        /// </summary>
        [EnumMember(Value = "received")]
        Received,

        /// <summary>
        /// The customer or seller canceled the order
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// TODO: Not documented
        /// </summary>
        [EnumMember(Value = "sent_and_autopaid")]
        SentAndAutopaid,

        /// <summary>
        /// The customer returned the product.
        /// </summary>
        [EnumMember(Value = "returned")]
        Returned,

        /// <summary>
        /// TODO: Not documented
        /// </summary>
        [EnumMember(Value = "returned_paid")]
        ReturnedPaid
    }
}
