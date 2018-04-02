using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class DoubleExtensions
    {
        public static readonly double DefaultTolerance = 0.0001d;

        public static bool IsClose(this double x, double y, double tolerance)
        {
            return Math.Abs(x - y) < tolerance;
        }

        public static bool IsClose(this double x, double y)
        {
            return IsClose(x, y, DefaultTolerance);
        }
    }
}