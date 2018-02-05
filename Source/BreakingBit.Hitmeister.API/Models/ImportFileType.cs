using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The file type describes the file format and how this file is handled
    /// from the Hitmeister System.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImportFileType
    {
        /// <summary>
        /// A file which describes the complete inventory data for every item you are offering for sale.
        /// </summary>
        [EnumMember(Value = "DUMP")]
        Dump,

        /// <summary>
        /// A file which only contains the differences between your current inventory and the data in the Hitmeister system.
        /// </summary>
        [EnumMember(Value = "COMMAND")]
        Command,

        /// <summary>
        /// A CSV file pushing new/updated product data.
        /// </summary>
        [EnumMember(Value = "PRODUCT_FEED")]
        ProductFeed
    }
}
