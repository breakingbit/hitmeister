using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Information about the status of your product data, including whether or not an item has 
    /// been created and if it is available on our site. 
    /// </summary>
    public sealed class ProductDataStatus
    {
        /// <summary>
        /// A reason why the item is not yet ready.
        /// </summary>
        [JsonProperty("item_not_ready_reason", Required = Required.Default)]
        public ItemNotReadyReason? ItemNotReadyReason { get; set; }

        /// <summary>
        /// The status of your requested update
        /// </summary>
        /// <value>The status of your requested update</value>
        [JsonProperty("update_status", Required = Required.Always)]
        public ProductDataUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// If the update failed, this field contains the reason why.
        /// </summary>
        [JsonProperty("update_fail_reason", Required = Required.Default)]
        public ProductDataUpdateFailReason? UpdateFailReason { get; set; }

        /// <summary>
        /// Whether or not the item is ready and offers can be created for it
        /// </summary>
        [JsonProperty("item_ready", Required = Required.Always)]
        public bool ItemReady { get; set; }

        /// <summary>
        /// Internal ID of Item, unique across all Items
        /// </summary>
        /// <value>Optional unique identifier</value>
        [JsonProperty("id_item", Required = Required.Default)]
        public long? ItemIdentifier { get; set; }

        /// <summary>
        /// A numeric value between 0 and 1 describing the product data quality for this item. 
        /// 0 is worst. 1 is best.
        /// </summary>
        /// <value>[0, 1]</value>
        [JsonProperty("item_quality", Required = Required.Default)]
        public float? ItemQuality { get; set; }

        /// <summary>
        /// True if this item have values for all mandatory attributes.
        /// </summary>
        [JsonProperty("item_isvalid", Required = Required.Default)]
        public bool? ItemIsValid { get; set; }

        /// <summary>
        /// These attributes have to be added to make the item valid.
        /// </summary>
        /// <value>List of Attribute.Name</value>
        [JsonProperty("missing_mandatory_attributes", Required = Required.Default)]
        public List<string> MissingMandatoryAttributes { get; set; }

        /// <summary>
        /// At least one of these attributes needs to be added to make the item valid.
        /// </summary>
        /// <value>List of Attribute.Name</value>
        [JsonProperty("min_one_missing_attributes", Required = Required.Default)]
        public List<string> MinOneMissingAttributes { get; set; }

        /// <summary>
        /// All attribute updates and their review status.
        /// </summary>
        /// <value>List of Attribute values</value>
        [JsonProperty("attribute_values", Required = Required.Default)]
        public List<ProductDataStatusAttributeValue> AttributeValues { get; set; }
    }
}
