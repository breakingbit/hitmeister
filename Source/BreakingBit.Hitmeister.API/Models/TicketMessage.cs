using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A message used to communicate regarding a Ticket.
    /// </summary>
    /// <remarks>
    /// Tickets are issues related to orders that have been raised either by the buyer 
    /// or the seller. They are always bound to order units (for more information about 
    /// orders and order units, see the Managing Orders page). Once a ticket has been 
    /// opened, the seller, the buyer or the customer service communicate with each other 
    /// through sending messages.
    /// </remarks>
    public sealed class TicketMessage
    {
        /// <summary>
        /// Unique identifier of this message, unique across all TicketMessages
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_ticket_message", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// Internal identifier of Ticket, unique across all Tickets
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_claim", Required = Required.Always)]
        public int TicketIdentifier { get; set; }

        /// <summary>
        /// The Authors online representation
        /// </summary>
        [JsonProperty("author", Required = Required.Always)]
        public TicketMessageAuthor Author { get; set; }

        /// <summary>
        /// Message the Author wrote.
        /// </summary>
        /// <value>Free text</value>
        [JsonProperty("text", Required = Required.Always)]
        public string Text { get; set; }

        /// <summary>
        /// The date and time when this message was created. 
        /// </summary>
        /// <value>Timestamp of creation</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }
    }
}
