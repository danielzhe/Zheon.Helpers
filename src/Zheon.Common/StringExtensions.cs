using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string str, string other)
        {
            return string.Equals(str, other, StringComparison.OrdinalIgnoreCase);
        }

        public static bool EqualsOrdinal(this string str, string other)
        {
            return string.Equals(str, other, StringComparison.Ordinal);
        }
    }
}