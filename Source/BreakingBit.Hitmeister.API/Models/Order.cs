using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A partial order from a particular seller.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Encrypted ID of the Order
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_order", Required = Required.Always)]
        public string Identifier { get; set; }

        /// <summary>
        /// Date and time when this order has been created.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }
    }
}
