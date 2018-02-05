using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Item with optional additional information if requested.
    /// </summary>
    public sealed class ItemWithEmbedded : Item
    {
        /// <summary>
        /// The category this item belongs to, unique for each item.
        /// </summary>
        /// <value>Optional category</value>
        [JsonProperty("category")]
        public Category Category { get; set; }

        /// <summary>
        /// Units the seller offers for this item.
        /// </summary>
        /// <value>List of Unit</value>
        [JsonProperty("units")]
        public List<Unit> Units { get; set; }
    }
}
