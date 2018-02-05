using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Inventory data for a single item from a single seller.
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// The condition of the selling units 
        /// </summary>
        /// <value>Condition code</value>
        [JsonProperty("condition", Required = Required.Always)]
        public UnitCondition Condition { get; set; }

        /// <summary>
        /// Country code according to ISO 3166-2
        /// </summary>
        /// <value>ISO 3166-2 code</value>
        [JsonProperty("location", Required = Required.Always)]
        public Location Location { get; set; }

        /// <summary>
        /// The maximum amount of days this unit requires to be sent.
        /// </summary>
        /// <value>Maximum days</value>
        [JsonProperty("delivery_time", Required = Required.Always)]
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Internal identifier of Unit, unique across all Units
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_unit", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// Internal identifier of the Item
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_item", Required = Required.Always)]
        public long ItemIdentifier { get; set; }

        /// <summary>
        /// Seller defined name to identify a warehouse this unit is stored in.
        /// </summary>
        /// <value>Name of warehouse</value>
        [JsonProperty("warehouse", Required = Required.Always)]
        public string Warehouse { get; set; }

        /// <summary>
        /// Amount of available Units for sell
        /// </summary>
        /// <value>Count of units</value>
        [JsonProperty("amount", Required = Required.Always)]
        public int Amount { get; set; }

        /// <summary>
        /// Price at which this unit will be offered on Hitmeister
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("price", Required = Required.Always)]
        public int Price { get; set; }

        /// <summary>
        /// A shipping group specifies countries the item can be delivered to at which 
        /// price and by which carrier.
        /// </summary>
        /// <value>Shipping group identifier</value>
        [JsonProperty("shipping_group", Required = Required.Always)]
        public string ShippingGroup { get; set; }

        /// <summary>
        /// A note from the seller for non structured data references
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("note", Required = Required.Always)]
        public string Note { get; set; }

        /// <summary>
        /// A reference price of this product, not yet available
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("reference_price", Required = Required.Always)]
        public int ReferencePrice { get; set; }

        /// <summary>
        /// The seller of this unit
        /// </summary>
        [JsonProperty("seller", Required = Required.Always)]
        public Seller Seller { get; set; }

        /// <summary>
        /// Shipping costs derived from ShippingGroup
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("shipping_rate", Required = Required.Always)]
        public int ShippingRate { get; set; }
    }
}
