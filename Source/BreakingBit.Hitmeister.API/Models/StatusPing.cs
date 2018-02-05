using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Result of a status ping to the Hitmeister API
    /// </summary>
    public sealed class StatusPing
    {
        /// <summary>
        /// Response message of an API status ping
        /// </summary>
        /// <value>
        /// "Never tell me the odds." if successful
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
