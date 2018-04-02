using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class FloatExtensions
    {
        public static readonly float DefaultTolerance = 0.0001f;

        public static bool IsClose(this float x, float y, float tolerance)
        {
            return Math.Abs(x - y) < tolerance;
        }

        public static bool IsClose(this float x, float y)
        {
            return IsClose(x, y, DefaultTolerance);
        }
    }
}