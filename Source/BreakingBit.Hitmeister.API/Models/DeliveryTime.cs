using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes a delivery time
    /// </summary>
    /// <value>The maximum amount of days until the item must be shipped</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryTime : uint
    {

        /// <summary>
        /// On Stock.
        /// </summary>
        [EnumMember(Value = "a")]
        A = 0,

        /// <summary>
        /// Ships in 1-3 days.
        /// </summary>
        [EnumMember(Value = "b")]
        B = 3,

        /// <summary>
        /// Ships in 4-6 days.
        /// </summary>
        [EnumMember(Value = "c")]
        C = 6,

        /// <summary>
        /// Ships in 7-10 days.
        /// </summary>
        [EnumMember(Value = "d")]
        D = 10,

        /// <summary>
        /// Ships in 11-14 days.
        /// </summary>
        [EnumMember(Value = "e")]
        E = 14,

        /// <summary>
        /// Ships in 3-4 weeks.
        /// </summary>
        [EnumMember(Value = "f")]
        F = 4 * 7,

        /// <summary>
        /// Ships in 5-7 weeks.
        /// </summary>
        [EnumMember(Value = "g")]
        G = 7 * 7,

        /// <summary>
        /// When it's available or no shipping estimate possible.
        /// </summary>
        [EnumMember(Value = "h")]
        H = uint.MaxValue,

        /// <summary>
        /// Ships in 8-10 weeks.
        /// </summary>
        [EnumMember(Value = "i")]
        I = 10 * 7
    }
}
