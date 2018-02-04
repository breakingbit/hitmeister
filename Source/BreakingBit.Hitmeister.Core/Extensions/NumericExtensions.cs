using System;

namespace BreakingBit.Hitmeister.Core.Extensions
{
    /// <summary>
    /// Implements extension methods for numeric structs
    /// </summary>
    public static class NumericExtensions
    {
        #region CountDigits
        /// <summary>
        /// Counts the number of digits <paramref name="number"/> required in a decimal system
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number of digets required in a decimal system</returns>
        public static uint CountDigits(this ulong number) =>
            (uint)Math.Floor(Math.Log10(number) + 1);
        #endregion
    }
}
