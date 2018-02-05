using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A file uploaded to a claim
    /// </summary>
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public sealed class ClaimFile
    {
        /// <summary>
        /// The name of the file when it has been uploaded
        /// </summary>
        /// <value>A filename</value>
        [JsonProperty("filename", Required = Required.Always)]
        public string Filename { get; set; }

        /// <summary>
        /// Date and time of the file upload
        /// </summary>
        /// <value>Non documented string format</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// An Url to download the associated file
        /// </summary>
        /// <value>Download link</value>
        [JsonProperty("uri", Required = Required.Always)]
        public Uri Url { get; set; }
    }
}
