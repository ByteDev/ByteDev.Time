using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:ByteDev.Time.Month" />.
    /// </summary>
    public static class MonthExtensions
    {
        /// <summary>
        /// Returns a three character representation of the month.
        /// </summary>
        /// <param name="source">The month.</param>
        /// <returns>Short representation of the month.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="source" /> is not defined.</exception>
        public static string ToStringShort(this Month source)
        {
            if (!Enum.IsDefined(typeof(Month), source))
            {
                throw new ArgumentException($"No {typeof(Month)} defined for value: '{source}'.", nameof(source));
            }

            return source.ToString().Substring(0, 3);
        }
    }
}