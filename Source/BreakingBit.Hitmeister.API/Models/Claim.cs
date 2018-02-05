using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Claims are problems with an order that have been raised either by the buyer or the seller.
    /// </summary>
    /// <remarks>
    /// Once a claim has been opened all parties communicate using ClaimMessages.
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public class Claim
    {
        /// <summary>
        /// The current status. See ClaimStatus for explanation.
        /// </summary>
        /// <value>Current Status</value>
        [JsonProperty("status", Required = Required.Always)]
        public ClaimStatus Status { get; set; }

        /// <summary>
        /// The reason why this claim was opened.
        /// </summary>
        /// <value></value>
        [JsonProperty("open_reason", Required = Required.Always)]
        public ClaimOpenReason OpenReason { get; set; }

        /// <summary>
        /// Internal ID of Claim, unique across all Claims
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_claim", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// The identifier of the OrderUnit this claim is regarding to.
        /// </summary>
        /// <value>Associated OrderUnit identifier</value>
        [JsonProperty("id_order_unit", Required = Required.Always)]
        public long OrderUnitIdentifier { get; set; }

        /// <summary>
        /// They buyer identifier of the product associated in the OrderUnit
        /// </summary>
        /// <value>Unique identifier of the product buyer</value>
        [JsonProperty("id_buyer", Required = Required.Always)]
        public int BuyerIdentifier { get; set; }

        /// <summary>
        /// The date and time when this Claim was created
        /// </summary>
        /// <value>Timestamp of creation</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Date and time when this Claim was updated the last time
        /// </summary>
        /// <value>Timestamp of last modification</value>
        [JsonProperty("ts_updated", Required = Required.Always)]
        public DateTime LastUpdateTimestamp { get; set; }

        /// <summary>
        /// A phone number to call they buyer for a conversation.
        /// </summary>
        /// <value>A non checked phone number</value>
        [JsonProperty("callback_phone", Required = Required.Always)]
        public string CallbackPhoneNumber { get; set; }

        /// <summary>
        /// Indicates that the customer is waiting for you to respond
        /// </summary>
        /// <value>True iff seller response is acquired</value>
        [JsonProperty("is_seller_responsible", Required = Required.Always)]
        public bool IsSellerResponsible { get; set; }
    }
}
