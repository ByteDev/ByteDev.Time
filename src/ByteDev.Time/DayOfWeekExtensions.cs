using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DayOfWeek" />.
    /// </summary>
    public static class DayOfWeekExtensions
    {
        /// <summary>
        /// Returns a three character representation of the day of the week.
        /// </summary>
        /// <param name="source">The day of the week.</param>
        /// <returns>Short representation of the day of the week.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="source" /> is not defined.</exception>
        public static string ToStringShort(this DayOfWeek source)
        {
            if (!Enum.IsDefined(typeof(DayOfWeek), source))
            {
                throw new ArgumentException($"No {typeof(DayOfWeek)} defined for value: '{source}'.", nameof(source));
            }

            return source.ToString().Substring(0, 3);
        }
    }
}