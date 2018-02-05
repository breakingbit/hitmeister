using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The authors data who created a ClaimMessage
    /// </summary>
    [Obsolete("Claims are deprecated in favor for Tickets. Please use tickets in order to be conform with " +
        "the introduced N-to-N relation between tickets and order units. The claims and claim-messages endpoints " +
        "will be supported until November 2017.")]
    public sealed class ClaimMessageAuthor
    {
        /// <summary>
        /// The role the author takes regarding  the conversation
        /// </summary>
        /// <value>Role in conversation</value>
        [JsonProperty("role", Required = Required.Always)]
        public ClaimMessageAuthorRole Role { get; set; }

        /// <summary>
        /// The name of the author to be displayed
        /// </summary>
        /// <value>Display name</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
