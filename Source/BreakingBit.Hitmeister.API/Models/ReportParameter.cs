using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A string based key-value pair used as parameter for Report generation.
    /// </summary>
    public sealed class ReportParameter
    {
        // TODO: Ask for a detailed description of possible values.
        //       Maybe in the back end?

        /// <summary>
        /// Key/Name of the parameter.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Value of the parameter
        /// </summary>
        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }
}
