﻿using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The reason why a claim was opened.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public enum ClaimOpenReason
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
