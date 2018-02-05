using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes the status of a Return.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReturnStatus
    {
        /// <summary>
        /// The customer has requested to return one or more articles he bought.
        /// </summary>
        [EnumMember(Value = "return_requested")]
        ReturnRequested,

        /// <summary>
        /// The customer has received a return label from the respective shipping provider 
        /// (e.g DHL). This should usually happen a few moments after the return is requested.
        /// </summary>
        [EnumMember(Value = "label_generated")]
        LabelGenerated,

        /// <summary>
        /// The package was sent (according to the shipping provider).
        /// </summary>
        [EnumMember(Value = "package_sent")]
        PackageSent,

        /// <summary>
        /// The package was delivered (according to the shipping provider).
        /// </summary>
        [EnumMember(Value = "package_received")]
        PackageReceived,

        /// <summary>
        /// The generated label has been deleted.
        /// </summary>
        [EnumMember(Value = "label_deleted")]
        LabelDeleted
    }
}
