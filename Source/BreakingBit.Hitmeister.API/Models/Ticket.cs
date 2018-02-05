using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Tickets are issues related to orders that have been raised either by the buyer or the seller.
    /// </summary>
    /// <remarks>
    /// Once a ticket has been opened, the seller, the buyer or the customer service communicate 
    /// with each other through sending messages.
    /// </remarks>
    public class Ticket
    {
        /// <summary>
        /// The current status. See TicketStatus for explanation.
        /// </summary>
        /// <value>Current Status</value>
        [JsonProperty("status", Required = Required.Always)]
        public TicketStatus Status { get; set; }

        /// <summary>
        /// The reason why this Ticket was opened.
        /// </summary>
        [JsonProperty("open_reason", Required = Required.Always)]
        public TicketOpenReason OpenReason { get; set; }

        /// <summary>
        /// Internal identifier of Ticket, unique across all Tickets
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_ticket", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// A list of identifier of OrderUnits this ticket is regarding to.
        /// </summary>
        /// <value>Associated OrderUnit identifier</value>
        [JsonProperty("id_order_units", Required = Required.Always)]
        public List<long> OrderUnitIdentifiers { get; set; }

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
