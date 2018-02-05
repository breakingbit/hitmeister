using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Return of one or more articles a customer bought.
    /// </summary>
    public class Return
    {
        /// <summary>
        /// The TrackingProvider responsible for shipping the package from the
        /// customer to the seller's given address.
        /// </summary>
        [JsonProperty("tracking_provider", Required = Required.Always)]
        public TrackingProvider TrackingProvider { get; set; }

        /// <summary>
        /// The current status.
        /// </summary>
        [JsonProperty("status", Required = Required.Always)]
        public ReturnStatus Status { get; set; }

        /// <summary>
        /// Internal identifier of Return, unique across all Returns
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_return", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// Date and time when this Return has been created.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Date and time when this Return has been lastly updated.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_updated", Required = Required.Always)]
        public DateTime LastUpdateTimestamp { get; set; }

        /// <summary>
        /// A code provided by the TrackingProvider to track the package.
        /// </summary>
        /// <value>TrackingProvider defined string</value>
        [JsonProperty("tracking_code", Required = Required.Always)]
        public string TrackingCode { get; set; }
    }
}
