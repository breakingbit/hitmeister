using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A unit sold in an order with optionally embedded data.
    /// </summary>
    public sealed class OrderUnitWithEmbedded : OrderUnit
    {
        /// <summary>
        /// A list of tickets referencing this OrderUnit, see Ticket.OrderUnitIdentifiers
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("tickets", Required = Required.Default)]
        public List<Ticket> Tickets { get; set; }

        /// <summary>
        /// The current status of a return for this OrderUnit, if any.
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("return_unit", Required = Required.Default)]
        public ReturnUnit ReturnUnit { get; set; }
    }
}
