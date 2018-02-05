using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The gender of a person
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        /// <summary>
        /// Indicating a person is male
        /// </summary>
        [EnumMember(Value = "male")]
        Male,

        /// <summary>
        /// Indicating a person is female
        /// </summary>
        [EnumMember(Value = "female")]
        Female
    }
}
