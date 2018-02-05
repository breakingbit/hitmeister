using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The role a creator of a TicketMessage has in the conversation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketMessageAuthorRole
    {
        /// <summary>
        /// The creator is the seller of an associated unit sale.
        /// </summary>
        [EnumMember(Value = "seller")]
        Seller,

        /// <summary>
        /// The creator is the buyer of an associated unit sale.
        /// </summary>
        [EnumMember(Value = "buyer")]
        Buyer,

        /// <summary>
        /// The message was auto created from the system.
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// The customer service of the marketplace created the message.
        /// </summary>
        [EnumMember(Value = "customer_service")]
        Customerservice
    }
}
