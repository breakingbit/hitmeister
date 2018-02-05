using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes the current status of a report generation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportStatus
    {

        /// <summary>
        /// The Hitmeister system just received the job and has not yet started.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// The Hitmeister system is currently generating the report.
        /// </summary>
        [EnumMember(Value = "processing")]
        Processing,

        /// <summary>
        /// The report generation failed.
        /// </summary>
        [EnumMember(Value = "processing_failed")]
        ProcessingFailed,

        /// <summary>
        /// The report has been successfully generated and is available.
        /// </summary>
        [EnumMember(Value = "done")]
        Done,

        /// <summary>
        /// The generation has been canceled manually.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled
    }
}
