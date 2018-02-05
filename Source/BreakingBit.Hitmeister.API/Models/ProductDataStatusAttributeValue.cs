using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A suggested attribute value update for product data and its review state.
    /// </summary>
    public sealed class ProductDataStatusAttributeValue
    {
        /// <summary>
        /// The state of your value provided for this Attribute update.
        /// </summary>
        /// <value>The state of your value.</value>
        [JsonProperty("state", Required = Required.Always)]
        public ProductDataStatusAttributeValueState State { get; set; }

        /// <summary>
        /// The attribute the value belongs to.
        /// </summary>
        /// <value>Attribute.Name</value>
        [JsonProperty("attribute", Required = Required.Always)]
        public string Attribute { get; set; }

        /// <summary>
        /// The value you suggested for the item attribute.
        /// </summary>
        /// <value>User written string.</value>
        [JsonProperty("original_value", Required = Required.Always)]
        public string OriginalValue { get; set; }

        /// <summary>
        /// Text describing in more detail what happened to your value.
        /// </summary>
        /// <value>Free text.</value>
        [JsonProperty("message", Required = Required.Always)]
        public string Message { get; set; }
    }
}
