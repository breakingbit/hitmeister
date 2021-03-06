﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The reason why a ticket was opened.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketOpenReason
    {
        /// <summary>
        /// The product is not like it was described regarding the description.
        /// </summary>
        [EnumMember(Value = "product_not_as_described")]
        ProductNotAsDescribed,

        /// <summary>
        /// The product has a defect. 
        /// </summary>
        [EnumMember(Value = "product_defect")]
        ProductDefect,

        /// <summary>
        /// The product was not delivered or not received.
        /// </summary>
        [EnumMember(Value = "product_not_delivered")]
        ProductNotDelivered,

        /// <summary>
        /// The customer wants to return the product.
        /// </summary>
        [EnumMember(Value = "product_return")]
        ProductReturn,

        /// <summary>
        /// None of the other reasons matches.
        /// </summary>
        [EnumMember(Value = "contact_other")]
        ContactOther
    }
}
