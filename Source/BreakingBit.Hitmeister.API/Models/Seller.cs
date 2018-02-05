using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Online shop representation of a seller
    /// </summary>
    public sealed class Seller
    {
        /// <summary>
        /// Seller's shop name displayed online to the customers
        /// </summary>
        [JsonProperty("pseudonym", Required = Required.Always)]
        public string Pseudonym { get; set; }
    }
}
