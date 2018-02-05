using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Processing status of an CSV file import in the Hitmeister system.
    /// </summary>
    public sealed class ImportFile
    {
        /// <summary>
        /// Current processing status of this file within the Hitmeister import system.
        /// </summary>
        [JsonProperty("status", Required = Required.Always)]
        public ImportFileStatus Status { get; set; }

        /// <summary>
        /// The determining how this file gets processes by the Hitmeister system.
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public ImportFileType Type { get; set; }


        /// <summary>
        /// Internal identifier of Import File, unique across all Import Files
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_import_file", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// An URL the user provided to the Hitmeister system to download the import file.
        /// </summary>
        /// <value>User provided URL</value>
        [JsonProperty("uri", Required = Required.Always)]
        public Uri Url { get; set; }

        /// <summary>
        /// A note provided by the Hitmeister import system.
        /// </summary>
        /// <value>System string from Hitmeister</value>
        [JsonProperty("note", Required = Required.Always)]
        public string Note { get; set; }

        /// <summary>
        /// The total count of lines read from the provided CSV file.
        /// </summary>
        /// <value>Count of lines</value>
        [JsonProperty("total_lines", Required = Required.Always)]
        public int TotalLines { get; set; }

        /// <summary>
        /// The current line the Hitmeister import system is currently processing.
        /// </summary>
        /// <value>Index of line</value>
        [JsonProperty("current_line", Required = Required.Always)]
        public int CurrentLine { get; set; }

        /// <summary>
        /// Date and time when this import has been initialized.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Date and time when this import has been lastly modified.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_updated", Required = Required.Always)]
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Date and time when the last row has been imported.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_last_row_updated", Required = Required.Always)]
        public DateTime? LastRowUpdateTimestamp { get; set; }

        /// <summary>
        /// Date and time when this import completed.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_completed", Required = Required.Always)]
        public DateTime? CompletionTimestamp { get; set; }

        /// <summary>
        /// The amount of lines which emitted errors during processing.
        /// </summary>
        /// <value></value>
        [JsonProperty("error_count", Required = Required.Always)]
        public int ErrorCount { get; set; }

        /// <summary>
        /// If the import file is a product feed contains the lines processed asynchronously.
        /// </summary>
        /// <value>Count of lines</value>
        [JsonProperty("product_feed_async_done", Required = Required.Always)]
        public int ProductFeedAsyncDone { get; set; }
    }
}
