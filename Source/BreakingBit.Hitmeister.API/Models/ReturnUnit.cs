using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Status of a return associated to a singe OrderUnit.
    /// </summary>
    public sealed class ReturnUnit
    {
        /// <summary>
        /// The current status of the return process.
        /// </summary>
        [JsonProperty("status", Required = Required.Always)]
        public ReturnStatus Status { get; set; }

        /// <summary>
        /// The reason why the customer initiated a return.
        /// </summary>
        [JsonProperty("reason", Required = Required.Always)]
        public ReturnReason Reason { get; set; }

        /// <summary>
        /// A unique identifier for this ReturnUnit.
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_return_unit", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// Internal identifier of Return, unique across all Returns
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_return", Required = Required.Always)]
        public int ReturnIdentifier { get; set; }

        /// <summary>
        /// The bought OrderUnit's internal identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_order_unit", Required = Required.Always)]
        public long OrderUnitIdentifier { get; set; }

        /// <summary>
        /// Date and time when this return unit has been created.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// A note written by the customer.
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("note", Required = Required.Always)]
        public string Note { get; set; }
    }
}
