using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The review state of an attribute update.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductDataStatusAttributeValueState
    {

        /// <summary>
        /// The update has been accepted.
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        Accepted,

        /// <summary>
        /// The update has been declined.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        Declined,

        /// <summary>
        /// The value has been transformed during the review process.
        /// </summary>
        [EnumMember(Value = "TRANSFORMED")]
        Transformed,

        /// <summary>
        /// The update has been refused.
        /// </summary>
        [EnumMember(Value = "REFUSED")]
        Refused,

        /// <summary>
        /// The value has been modified during the review process.
        /// </summary>
        [EnumMember(Value = "MODIFIED")]
        Modified,

        /// <summary>
        /// The value update will be ignored
        /// </summary>
        [EnumMember(Value = "IGNORED")]
        Ignored,

        /// <summary>
        /// The review of this value update is pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Data for this attribute is missing.
        /// </summary>
        [EnumMember(Value = "MISSING")]
        Missing,

        /// <summary>
        /// At least on modification is missing to validate this value.
        /// </summary>
        [EnumMember(Value = "MIN_ONE_MISSING")]
        MinOneMissing
    }
}
