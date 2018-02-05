using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A partial order containing the count of units bought from a particular seller.
    /// </summary>
    public sealed class OrderSeller : Order
    {
        /// <summary>
        /// Number of OrderUnits bought from the seller with this order.
        /// </summary>
        /// <value>Number of Order Units from current Seller</value>
        [JsonProperty("seller_units_count", Required = Required.Always)]
        public int SellerUnitsCount { get; set; }
    }
}
