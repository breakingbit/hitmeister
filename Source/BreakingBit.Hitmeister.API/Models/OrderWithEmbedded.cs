using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A partial order from a particular seller with optionally embedded data.
    /// </summary>
    public sealed class OrderWithEmbedded : Order
    {
        /// <summary>
        /// The billing address of the customer who placed this order.
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("billing_address", Required = Required.Default)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The shipping address of the customer who placed this order.
        /// </summary>
        /// /// <value>Null if not embedded.</value>
        [JsonProperty("shipping_address", Required = Required.Default)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// The customer who placed this order.
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("buyer", Required = Required.Default)]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// A list of units sold with this order.
        /// </summary>
        /// <value>Null if not embedded.</value>
        [JsonProperty("seller_units", Required = Required.Default)]
        public List<OrderUnit> SellerUnits { get; set; }
    }
}
