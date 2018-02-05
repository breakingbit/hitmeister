using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Return of one or more articles a customer bought with optional
    /// additional data.
    /// </summary>
    public sealed class ReturnWithEmbedded : Return
    {
        /// <summary>
        /// A ReturnUnit for each unit the customer wants to return.
        /// </summary>
        [JsonProperty("units", Required = Required.Default)]
        public List<ReturnUnit> ReturnUnits { get; set; }

        /// <summary>
        /// The online representation of the customer who want to return.
        /// </summary>
        [JsonProperty("buyer", Required = Required.Default)]
        public Buyer Buyer { get; set; }
    }
}
