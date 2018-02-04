using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Attribute describes one or more pieces of information about an item. 
    /// </summary>
    /// <remarks>
    /// Every item consists of a set of attributes and their values. Each attribute describes one or
    /// more pieces of information about an item. For example, the title attribute contains the name or title of 
    /// an item and the picture attribute contains a collection of pictures of the item. There are both mandatory 
    /// attributes and optional attributes. When you submit item data, each item must 
    /// have a value for all mandatory attributes, but option attributes can be missing.
    /// </remarks>
    public sealed class Attribute
    {
        /// <summary>
        /// The type of value that the attribute accepts.
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public AttributeType Type { get; set; }

        /// <summary>
        /// Internal ID of attribute, unique across all attributes
        /// Since an attribute can exist in multiple categories, this ID identifies an attribute across categories.
        /// </summary>
        /// <value>Internal ID of attribute, unique across all attributes</value>
        [JsonProperty("id_attribute", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// The English name of the attribute. You should use this name when submitting product data.
        /// </summary>
        /// <value>The technical name of an attribute.</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// The German name of the attribute. This name is displayed to the user on the Hitmeister website.
        /// </summary>
        /// <value>The title / display name of an attribute</value>
        [JsonProperty("title", Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Whether it is possible to store multiple values in an attribute
        /// </summary>
        /// <value>Whether it is possible to store multiple values in an attribute</value>
        [JsonProperty("is_multiple_allowed", Required = Required.Always)]
        public bool IsMultipleAllowed { get; set; }
    }

}
