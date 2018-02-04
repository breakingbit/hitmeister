namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The underlying norm an <see cref="Ean"/> conforms to
    /// </summary>
    /// <remarks>
    /// To obtain the number of digits an <see cref="EanType"/> can store simply
    /// cast it to its implementation type.
    /// <code>
    ///     var maximumNumberOfDigits = (uint)EANType.GTIN_13;
    /// </code>
    /// </remarks>
    public enum EanType : uint
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
