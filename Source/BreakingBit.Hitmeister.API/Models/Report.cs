using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Data of a generated or generating summary reports about inventory and sales data.
    /// </summary>
    public sealed class Report
    {
        /// <summary>
        /// The current status of report generation.
        /// </summary>
        [JsonProperty("status", Required = Required.Always)]
        public ReportStatus Status { get; set; }

        /// <summary>
        /// Internal identifier of Report, unique across all Reports
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_report", Required = Required.Always)]
        public long IdReport { get; set; }

        /// <summary>
        /// Date and time when the report has been requested.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("date_requested", Required = Required.Always)]
        public DateTime DateRequested { get; set; }

        /// <summary>
        /// URL to download the report.
        /// </summary>
        /// <value>Null if not ready</value>
        [JsonProperty("url", Required = Required.AllowNull)]
        public Uri Url { get; set; }

        /// <summary>
        /// A collection of parameters passed to the report generation.
        /// </summary>
        [JsonProperty("params", Required = Required.Always)]
        public List<ReportParameter> Parameters { get; set; }
    }
}
