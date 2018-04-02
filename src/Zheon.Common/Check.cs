using System;
using System.Diagnostics;

namespace Zheon.Common
{
    [DebuggerStepThrough]
    public static class Check
    {
        /// <summary>
        ///     Check if an object is null. Throws ArgumentException if it is.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="obj">Object to check if it is null or not.</param>
        /// <param name="argName">Argument name.</param>
        public static void IsNotNull<T>(T obj, string argName) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentException($"'{argName}' can not be null.");
            }
        }

        /// <summary>
        ///     Check if a nullable struct is null. Throws ArgumentException if it is.
        /// </summary>
        /// <typeparam name="T">Type of the struct.</typeparam>
        /// <param name="strc">Nullable to check if it is null.</param>
        /// <param name="argName">Argument name.</param>
        public static void IsNotNull<T>(T? strc, string argName) where T : struct
        {
            if (strc == null)
            {
                throw new ArgumentException($"'{argName}' can not be null.");
            }
        }

        /// <summary>
        ///     Check if an string is null or empty. Throws ArgumentException if it is.
        /// </summary>
        /// <exception cref="ArgumentException">If string is null or empty.</exception>
        /// <param name="str">String to check.</param>
        /// <param name="argName">Argument name.</param>
        public static void IsNotNullOrEmpty(string str, string argName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException($"'{argName}' can not be null or empty.");
            }
        }

        /// <summary>
        ///     Check if an object is an instance of a type. Throws ArgumentException if it IS NOT.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="obj">Object to check.</param>
        /// <param name="argName">Argument name.</param>
        /// <returns>The object casted to T</returns>
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