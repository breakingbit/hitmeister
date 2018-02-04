using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The authors data who created a ClaimMessage
    /// </summary>
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
