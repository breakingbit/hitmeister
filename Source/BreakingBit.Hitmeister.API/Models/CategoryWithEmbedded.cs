using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A category extension which embeds referenced data if the appropriate
    /// embedding was set during the request.
    /// </summary>
    public sealed class CategoryWithEmbedded : Category
    {
        /// <summary>
        /// The parent category data
        /// </summary>
        /// <value>Parent data</value>
        [JsonProperty("parent", Required = Required.Default)]
        public Category Parent { get; set; }

        /// <summary>
        /// All children referencing this category as parent
        /// </summary>
        /// <value>Children data</value>
        [JsonProperty("children", Required = Required.Default)]
        public List<Category> Children { get; set; }

        /// <summary>
        /// A list of optional attributes referenced by items of this category
        /// </summary>
        /// <value>Optional attributes for category items</value>
        [JsonProperty("optional_attributes", Required = Required.Default)]
        public List<Attribute> OptionalAttributes { get; set; }

        /// <summary>
        /// A list of mandatory attributes referenced by items of this category
        /// </summary>
        /// <value>Mandatory attributes for category items</value>
        [JsonProperty("mandatory_attributes", Required = Required.Default)]
        public List<Attribute> MandatoryAttributes { get; set; }
    }
}
