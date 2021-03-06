﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The current status for a ticket.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketStatus
    {
        /// <summary>
        /// The ticket was just opened.
        /// </summary>
        [EnumMember(Value = "opened")]
        Opened,

        /// <summary>
        /// The buyer closed the ticket.
        /// </summary>
        [EnumMember(Value = "buyer_closed")]
        BuyerClosed,

        /// <summary>
        /// The seller closed the ticket.
        /// </summary>
        [EnumMember(Value = "seller_closed")]
        SellerClosed,

        /// <summary>
        /// The buyer and seller closed the ticket.
        /// </summary>
        [EnumMember(Value = "both_closed")]
        BothClosed,

        /// <summary>
        /// The customer service closed the ticket.
        /// </summary>
        [EnumMember(Value = "customer_service_closed_final")]
        CustomerServiceClosedFinal
    }
}
