namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The underlying norm an <see cref="EAN"/> conforms to
    /// </summary>
    public enum EANType : uint
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
