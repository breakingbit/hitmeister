using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes a reason why the update of product data failed.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductDataUpdateFailReason
    {

        /// <summary>
        /// The product data has no associated item.
        /// </summary>
        [EnumMember(Value = "NO_ITEM")]
        NoItem,

        /// <summary>
        /// The product data has not enough text.
        /// </summary>
        [EnumMember(Value = "NOT_ENOUGH_TEXT")]
        NotEnoughText,

        /// <summary>
        /// The product data as no associated category.
        /// </summary>
        [EnumMember(Value = "NO_CATEGORY")]
        NoCategory,

        /// <summary>
        /// The product data is missing essential data.
        /// </summary>
        [EnumMember(Value = "NOT_ENOUGH_DATA")]
        NotEnoughData,

        /// <summary>
        /// The item processing failed.
        /// </summary>
        [EnumMember(Value = "ITEM_FAIL")]
        ItemFail
    }
}
