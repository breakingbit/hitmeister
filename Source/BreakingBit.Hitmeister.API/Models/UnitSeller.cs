using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Inventory data for a single item from a single seller with additionally
    /// seller data and optional embeddings.
    /// </summary>
    public sealed class UnitSeller : Unit
    {
        /// <summary>
        /// Listing price, available only for Seller.
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("listing_price", Required = Required.Always)]
        public int ListingPrice { get; set; }

        /// <summary>
        /// Minimum price, available only for Seller with enabled auto price adjustment.
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("minimum_price", Required = Required.Always)]
        public int MinimumPrice { get; set; }

        /// <summary>
        /// Seller's unique ID for offer(s).
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("id_offer", Required = Required.AllowNull)]
        public string OfferIdentifier { get; set; }

        /// <summary>
        /// The product data of this unit.
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("item", Required = Required.Default)]
        public Item Item { get; set; }
    }
}
