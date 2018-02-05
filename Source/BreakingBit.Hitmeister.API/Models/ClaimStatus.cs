using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The current status for a claim.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public enum ClaimStatus
    {
        /// <summary>
        /// The claim was just opened.
        /// </summary>
        [EnumMember(Value = "opened")]
        Opened,

        /// <summary>
        /// The buyer closed the claim.
        /// </summary>
        [EnumMember(Value = "buyer_closed")]
        BuyerClosed,

        /// <summary>
        /// The seller closed the claim.
        /// </summary>
        [EnumMember(Value = "seller_closed")]
        SellerClosed,

        /// <summary>
        /// The buyer and seller closed the claim.
        /// </summary>
        [EnumMember(Value = "both_closed")]
        BothClosed,

        /// <summary>
        /// The customer service closed the claim.
        /// </summary>
        [EnumMember(Value = "customer_service_closed_final")]
        CustomerServiceClosedFinal
    }
}
