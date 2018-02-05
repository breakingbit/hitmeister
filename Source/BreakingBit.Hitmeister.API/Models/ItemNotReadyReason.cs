using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A reason why product data for an items is not ready.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemNotReadyReason
    {

        /// <summary>
        /// The corresponding item is blacklisted by Hitmeister.
        /// </summary>
        [EnumMember(Value = "BLACKLISTED")]
        Blacklisted,

        /// <summary>
        /// The corresponding item is associated with porn.
        /// </summary>
        [EnumMember(Value = "PORN_FORBIDDEN")]
        PornForbidden,

        /// <summary>
        /// Mandatory attributes are missing.
        /// </summary>
        [EnumMember(Value = "MISSING_ATTRIBUTES")]
        MissingAttributes,

        /// <summary>
        /// The item has not been processed yet.
        /// </summary>
        [EnumMember(Value = "NOT_YET_PROCESSED")]
        NotYetProcessed,

        /// <summary>
        /// Processing has failed.
        /// </summary>
        [EnumMember(Value = "PROCESSING_FAILED")]
        ProcessingFailed
    }
}
