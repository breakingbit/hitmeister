using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// An encoded reason why a customer returns a bought product.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReturnReason
    {

        /// <summary>
        /// Generally just return.
        /// </summary>
        [EnumMember(Value = "return")]
        Return,

        /// <summary>
        /// None of the other reasons fits.
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// The customer did not want to give a reason.
        /// </summary>
        [EnumMember(Value = "no_reason")]
        Noreason,

        /// <summary>
        /// The arrived product is defect.
        /// </summary>
        [EnumMember(Value = "defect")]
        Defect,

        /// <summary>
        /// The product arrived is not the article the customer expected.
        /// </summary>
        [EnumMember(Value = "wrong_article")]
        Wrongarticle,

        /// <summary>
        /// The product has the wrong size.
        /// </summary>
        [EnumMember(Value = "wrong_size")]
        Wrongsize,

        /// <summary>
        /// The product shipment takes/took to long.
        /// </summary>
        [EnumMember(Value = "too_late")]
        Toolate,

        /// <summary>
        /// The product quality does not fit the customer's needs.
        /// </summary>
        [EnumMember(Value = "bad_quality")]
        Badquality
    }
}
