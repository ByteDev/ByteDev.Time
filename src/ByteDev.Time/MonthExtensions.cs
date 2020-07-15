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
        /// <param name="source">The <see cref="T:ByteDev.Time.Month" /> to use.</param>
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

        /// <summary>
        /// Returns the days in the month based on the supplied year.
        /// </summary>
        /// <param name="source">The <see cref="T:ByteDev.Time.Month" /> to use.</param>
        /// <param name="year">Year to use when calculating the month length.</param>
        /// <returns>Number of days in the month of <paramref name="source" />.</returns>
        public static int Length(this Month source, int year)
        {
            return DateTime.DaysInMonth(year, (int)source);
        }
    }
}