namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The underlying norm an <see cref="EAN"/> conforms to
    /// </summary>
#pragma warning disable S2342 // EAN is an abbreviation
    public enum EANType : uint
#pragma warning restore S2342 // EAN is an abbreviation
    {
        /// <summary>
        /// A 13 digits long article number
        /// </summary>
        GTIN_13 = 13,

        /// <summary>
        /// A 14 digits long article number
        /// </summary>
        GTIN_14 = 14
    }
}
