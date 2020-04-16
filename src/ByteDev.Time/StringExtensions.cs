using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.String" />.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a string with additional plural suffix. 
        /// </summary>
        /// <param name="source">The string to perform the operation on.</param>
        /// <param name="number">The number to base the plural on.</param>
        /// <returns>String with an required plural suffix.</returns>
        public static string Pluralize(this string source, int number)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            number = Math.Abs(number); // -1 should be singular, too
            return source + (number == 1 ? string.Empty : "s");
        }
    }
}

