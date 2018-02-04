using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes the condition of a product.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderUnitCondition
    {
        /// <summary>
        /// The product is new
        /// </summary>
        [EnumMember(Value = "100")]
        Code_100 = 100,

        /// <summary>
        /// The product is used but in condition like a new one
        /// </summary>
        [EnumMember(Value = "200")]
        Code_200 = 200,

        /// <summary>
        /// The product is used and has minor hints of use.
        /// </summary>
        [EnumMember(Value = "300")]
        Code_300 = 300,

        /// <summary>
        /// The product is used and has hints of use.
        /// </summary>
        [EnumMember(Value = "400")]
        Code_400 = 400,

        /// <summary>
        /// The product is used and has noticeable hints of use.
        /// </summary>
        [EnumMember(Value = "500")]
        Code_500 = 500,

        /// <summary>
        /// The product is a downloadable content.
        /// </summary>
        [EnumMember(Value = "900")]
        Code_900 = 900,

        /// <summary>
        /// The product is new
        /// </summary>
        [EnumMember(Value = "new")]
        New = Code_100,

        /// <summary>
        /// The product is used but in condition like a new one
        /// </summary>
        [EnumMember(Value = "used - as new")]
        UsedAsNew = Code_200,

        /// <summary>
        /// The product is used and has minor hints of use.
        /// </summary>
        [EnumMember(Value = "used - very good")]
        UsedVeryGood = Code_300,

        /// <summary>
        /// The product is used and has hints of use.
        /// </summary>
        [EnumMember(Value = "used - good")]
        UsedGood = Code_400,

        /// <summary>
        /// The product is used and has noticeable hints of use.
        /// </summary>
        [EnumMember(Value = "used - acceptable")]
        UsedAcceptable = Code_500,

        /// <summary>
        /// The product is a downloadable content.
        /// </summary>
        [EnumMember(Value = "download")]
        Download = Code_900
    }
}
