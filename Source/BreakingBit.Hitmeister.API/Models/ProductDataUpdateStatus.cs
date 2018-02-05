using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The status of your requested update
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductDataUpdateStatus
    {

        /// <summary>
        /// The update is waiting for review.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// The update is currently in review.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        /// The update succeeded.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// The update failed. See ProductDataStaus.FailReason
        /// </summary>
        [EnumMember(Value = "FAIL")]
        Fail
    }
}
