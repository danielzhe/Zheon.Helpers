using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class DoubleExtensions
    {
        /// <summary>
        ///     The default tolerance.
        /// </summary>
        public static readonly double DefaultTolerance = 0.0001d;

        /// <summary>
        ///     Check if an double is close ("almost equals") from another one.
        /// </summary>
        /// <param name="x">This double.</param>
        /// <param name="y">Other double to compare.</param>
        /// <param name="tolerance">Tolerance.</param>
        /// <returns>True if it is close considering tolerance. False otherwise.</returns>
        public static bool IsClose(this double x, double y, double tolerance)
        {
            return Math.Abs(x - y) < tolerance;
        }

        /// <summary>
        ///     Check if an double is close ("almost equals") from another one using DefaultTolerance.
        /// </summary>
        /// <param name="x">This double.</param>
        /// <param name="y">Other double to compare.</param>
        /// <returns>True if it is close considering tolerance. False otherwise.</returns>
        public static bool IsClose(this double x, double y)
        {
            return IsClose(x, y, DefaultTolerance);
        }
    }
}