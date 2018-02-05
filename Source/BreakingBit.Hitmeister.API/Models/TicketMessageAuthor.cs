using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The authors data who created a TicketMessage
    /// </summary>
    public sealed class TicketMessageAuthor
    {
        /// <summary>
        /// The role the author takes regarding the conversation
        /// </summary>
        /// <value>Role in conversation</value>
        [JsonProperty("role", Required = Required.Always)]
        public TicketMessageAuthorRole Role { get; set; }

        /// <summary>
        /// The name of the author to be displayed
        /// </summary>
        /// <value>Display name</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
