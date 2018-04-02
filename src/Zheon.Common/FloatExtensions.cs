using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class FloatExtensions
    {
        /// <summary>
        ///     The default tolerance.
        /// </summary>
        public static readonly float DefaultTolerance = 0.0001f;

        /// <summary>
        ///     Check if an float is close ("almost equals") from another one.
        /// </summary>
        /// <param name="x">This float.</param>
        /// <param name="y">Other float to compare.</param>
        /// <param name="tolerance">Tolerance.</param>
        /// <returns>True if it is close considering tolerance. False otherwise.</returns>
        public static bool IsClose(this float x, float y, float tolerance)
        {
            return Math.Abs(x - y) < tolerance;
        }

        /// <summary>
        ///     Check if an float is close ("almost equals") from another one.
        /// </summary>
        /// <param name="x">This float.</param>
        /// <param name="y">Other float to compare.</param>
        /// <returns>True if it is close considering tolerance. False otherwise.</returns>
        public static bool IsClose(this float x, float y)
        {
            return IsClose(x, y, DefaultTolerance);
        }
    }
}