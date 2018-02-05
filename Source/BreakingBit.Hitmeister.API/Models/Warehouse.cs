using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Data of a building used to store products.
    /// </summary>
    public sealed class Warehouse
    {
        /// <summary>
        /// Internal identifier of Warehouse, unique across all Warehouses
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_warehouse", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// A name given by the user for identification.
        /// </summary>
        /// <value>User defined string</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonProperty("address", Required = Required.Always)]
        public WarehouseAddress Address { get; set; }

        /// <summary>
        /// Is pickup possible for this Warehouse.
        /// </summary>
        /// <value>Flag</value>
        [JsonProperty("is_pickup_possible", Required = Required.Always)]
        public bool IsPickupPossible { get; set; }

        /// <summary>
        /// Is this Warehouse used as default.
        /// </summary>
        /// <value>Flag</value>
        [JsonProperty("is_default", Required = Required.Always)]
        public bool? IsDefault { get; set; }
    }
}
