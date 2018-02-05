using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A shipping definition created with the Hitmeister back end.
    /// </summary>
    public sealed class ShippingGroup
    {
        /// <summary>
        /// A unique name for this ShippingGroup given by the user.
        /// </summary>
        /// <value>Unique user defined identifier</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
