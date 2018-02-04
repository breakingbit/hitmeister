using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The particulars of a buyer
    /// </summary>
    public sealed class Buyer
    {
        /// <summary>
        /// The buyer's internal id, unique across all buyers
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_buyer", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// The email address given by the user
        /// </summary>
        /// <value>An email address</value>
        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }
    }
}
