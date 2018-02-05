using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A string based key-value pair describing a report's column.
    /// </summary>
    public sealed class ReportParameter
    {
        /// <summary>
        /// Key/Name of the parameter/column.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// The description of this column.
        /// </summary>
        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }
}
