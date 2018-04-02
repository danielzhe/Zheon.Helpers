using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class Check
    {
        public static void IsNotNull<T>(T obj, string argName) where T : class 
        {
            if (obj == null)
            {
                throw new ArgumentException($"'{argName}' can not be null.");
            }
        }

        public static void IsNotNull<T>(T? strc, string argName) where T : struct
        {
            if (strc == null)
            {
                throw new ArgumentException($"'{argName}' can not be null.");
            }
        }

        public static void IsNotNullOrEmpty(string str, string argName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException($"'{argName}' can not be null or empty.");
            }
        }

        public static T IsTypeOf<T>(object obj, string argName)
        {
            if (obj is T result)
            {
                return result;
            }

            throw new ArgumentException($"'{argName}' must be of the type '{typeof(T).FullName}'.");
        }
    }
}