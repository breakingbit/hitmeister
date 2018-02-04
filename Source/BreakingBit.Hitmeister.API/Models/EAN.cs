using System;
using System.Collections.Generic;
using System.Linq;
using BreakingBit.Hitmeister.Core.Extensions;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Wrapper for the string based european article number representation
    /// </summary>
    /// <remarks>
    /// The hitmeister api uses a string representation for their article numbers
    /// prepended with zeros. This conforms to the GTIN-13/14 norm. Hitmeister
    /// uses both norms.
    /// 
    /// GTIN-13 and 14 can be converted into each other by adding or discarding
    /// a leading zero. Thus <see cref="GetHashCode"/> and <see cref="Equals(EAN)"/>
    /// does not take the <see cref="EANType"/> into account because they basically
    /// represent the same article number in different norms if their numeric
    /// value is the same.
    /// </remarks>
    public class EAN : IEquatable<EAN>
    {
        #region Properties
        /// <summary>
        /// The parsed article number storead as <see cref="ulong"/> without prepending zeros.
        /// </summary>
        public ulong Number { get; }

        /// <summary>
        /// The underlying GTIN norm this <see cref="EAN"/> conforms to.
        /// </summary>
        public EANType Type { get; }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new article number storing the corresponding type
        /// </summary>
        /// <param name="articleNumber">numeric representation of the article number</param>
        /// <param name="type">the norm this article number conforms to</param>
        /// <exception cref="OverflowException">
        ///     The <paramref name="articleNumber"/> requires more digits than the corresponding
        ///     <see cref="EANType"/> can store.
        /// </exception>
        public EAN(ulong articleNumber, EANType type)
        {
            // Check the maximum number of digits is not exceeded
            var maximumNumberOfDigits = (uint)type;
            var numberOfDigits = articleNumber.CountDigits();
            if (numberOfDigits > maximumNumberOfDigits)
                throw new OverflowException($"An {nameof(EAN)} of type '{type}' cannot have more" +
                    $" than {maximumNumberOfDigits} digits.");

            // Store properties
            Number = articleNumber;
            Type = type;
        }
        #endregion

        #region Parsing
        /// <summary>
        /// Parses a string to an <see cref="EAN"/> with a fixed <see cref="EANType"/>
        /// </summary>
        /// <param name="articleNumber">the string representation of the article number</param>
        /// <param name="type">the corresponding <see cref="EANType"/> for this article number</param>
        /// <returns></returns>
        /// <exception cref="FormatException">
        ///     <paramref name="articleNumber"/> has an invalid format for a number
        /// </exception>
        /// <exception cref="OverflowException">
        ///     <paramref name="articleNumber"/> requires more digits than the correpsonding
        ///     <see cref="EANType"/> <paramref name="type"/>.
        /// </exception>
        public static EAN Parse(string articleNumber, EANType type)
        {
            var number = ulong.Parse(articleNumber);
            return new EAN(number, type);
        }

        /// <summary>
        /// Parses a string to an ean and determines its <see cref="EANType"/>
        /// </summary>
        /// <param name="articleNumber">the string representation of the article number</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="articleNumber"/> is null</exception>
        /// <exception cref="FormatException">
        ///     <paramref name="articleNumber"/> has an invalid format for a unsigned number
        /// </exception>
        /// <exception cref="OverflowException">
        ///     <paramref name="articleNumber"/> requires more digits than the correpsonding
        ///     <see cref="EANType"/> <paramref name="type"/>.
        /// </exception>
        public static EAN Parse(string articleNumber)
        {
            if (articleNumber == null)
                throw new ArgumentNullException(nameof(articleNumber));

            // Search for a corresponding type based on the strings length
            EANType? conformingType = null;
            foreach (var type in Enum.GetValues(typeof(EANType)).Cast<EANType>())
            {
                if ((uint)type == articleNumber.Length)
                {
                    conformingType = type;
                    break;
                }
            }


            if (!conformingType.HasValue)
                throw new FormatException("The provided article number does not conform to a specific norm.");
            else
                return Parse(articleNumber, conformingType.Value);
        }

        /// <summary>
        /// Tries to parse a string to an <see cref="EAN"/> with a fixed <see cref="EANType"/>
        /// </summary>
        /// <param name="articleNumber">the string representation of this article number</param>
        /// <param name="type">the assumed <see cref="EANType"/></param>
        /// <param name="ean">References the parsed <see cref="EAN"/> if successfull, otherwise null</param>
        /// <returns>True if the <see cref="EAN"/> could be parse successfully otherwise false</returns>
        public static bool TryParse(string articleNumber, EANType type, out EAN ean)
        {
            try
            {
                ean = Parse(articleNumber, type);
                return true;
            }
            catch (Exception)
            {
                ean = null;
                return false;
            }
        }

        /// <summary>
        /// Tries to parse a string to an <see cref="EAN"/> determening the corresponding
        /// <see cref="EANType"/> by the <paramref name="articleNumber"/> length.
        /// </summary>
        /// <param name="articleNumber">the string representation of this article number</param>
        /// <param name="ean">References the parsed <see cref="EAN"/> if successfull, otherwise null</param>
        /// <returns>True if the <see cref="EAN"/> could be parse successfully otherwise false</returns>
        public static bool TryParse(string articleNumber, out EAN ean)
        {
            try
            {
                ean = Parse(articleNumber);
                return true;
            }
            catch (Exception)
            {
                ean = null;
                return false;
            }
        }
        #endregion

        #region Comparison
        /// <summary>
        /// Overrides the base <see cref="object.Equals(object)"/> to compare
        /// against an object of type <see cref="EAN"/>.
        /// </summary>
        /// <param name="obj"><see cref="object"/> to compare as <see cref="EAN"/></param>
        /// <returns>
        ///     true if <paramref name="obj"/> is an <see cref="EAN"/> and has the
        ///     the same <see cref="Number"/> otherwise false
        /// </returns>
        public override bool Equals(object obj) =>
            Equals(obj as EAN);

        /// <summary>
        /// Checks if both <see cref="EAN"/>s have the same <see cref="Number"/>
        /// </summary>
        /// <param name="other">The <see cref="EAN"/> to compare to</param>
        /// <returns>
        ///     True if the <see cref="Number"/> properties are equal otherwise false
        /// </returns>
        public bool Equals(EAN other) =>
            other != null && Number == other.Number;

        /// <summary>
        /// Overrides <see cref="object.GetHashCode()"/> to a <see cref="Number"/> based hash code
        /// </summary>
        /// <returns>
        ///     A hash code representing the <see cref="Number"/> independent of its <see cref="Type"/>
        /// </returns>
        public override int GetHashCode() =>
            Number.GetHashCode();

        /// <summary>
        /// Determines whether two <see cref="EAN"/>s have the same <see cref="Number"/> property.
        /// </summary>
        /// <param name="ean1">The frist <see cref="EAN"/> to compare.</param>
        /// <param name="ean2">The second <see cref="EAN"/> to compare.</param>
        /// <returns>
        /// true if the <see cref="Number"/> of <paramref name="ean1"/> is the same as the 
        /// <see cref="Numer"/> of <paramref name="ean2"/>
        /// </returns>
        public static bool operator ==(EAN ean1, EAN ean2) =>
            EqualityComparer<EAN>.Default.Equals(ean1, ean2);

        /// <summary>
        /// Determines whether two <see cref="EAN"/>s have a different <see cref="Number"/> property.
        /// </summary>
        /// <param name="ean1">The frist <see cref="EAN"/> to compare.</param>
        /// <param name="ean2">The second <see cref="EAN"/> to compare.</param>
        /// <returns>
        /// true if the <see cref="Number"/> of <paramref name="ean1"/> is different from the
        /// <see cref="Numer"/> of <paramref name="ean2"/>
        /// </returns>
        public static bool operator !=(EAN ean1, EAN ean2) =>
            !(ean1 == ean2);
        #endregion
    }
}
