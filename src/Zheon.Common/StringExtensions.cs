using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class StringExtensions
    {
        /// <summary>
        ///     Check if one string is equals to another using StringComparison.OrdinalIgnoreCase.
        /// </summary>
        /// <param name="str">This string.</param>
        /// <param name="other">The other string to compare.</param>
        /// <returns>True if it is equals. False otherwise.</returns>
        public static bool EqualsIgnoreCase(this string str, string other)
        {
            return string.Equals(str, other, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        ///     Check if one string is equals to another using StringComparison.Ordinal.
        /// </summary>
        /// <param name="str">This string.</param>
        /// <param name="other">The other string to compare.</param>
        /// <returns>True if it is equals. False otherwise.</returns>
        public static bool EqualsOrdinal(this string str, string other)
        {
            return string.Equals(str, other, StringComparison.Ordinal);
        }
    }
}