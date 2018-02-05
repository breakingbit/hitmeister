using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The role a creator of a claim message has in the conversation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public enum ClaimMessageAuthorRole
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
