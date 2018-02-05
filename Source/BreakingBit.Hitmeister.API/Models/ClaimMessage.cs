using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A message used to communicate regarding a claim.
    /// </summary>
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public sealed class ClaimMessage
    {
        /// <summary>
        /// Unique identifier of this message, unique across all ClaimMessages
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_claim_message", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// Internal identifier of Claim, unique across all Claims
        /// </summary>
        /// <value>Unique identifier of associated claim</value>
        [JsonProperty("id_claim", Required = Required.Always)]
        public int ClaimIdentifier { get; set; }

        /// <summary>
        /// The Authors online representation
        /// </summary>
        [JsonProperty("author", Required = Required.Always)]
        public ClaimMessageAuthor Author { get; set; }

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
