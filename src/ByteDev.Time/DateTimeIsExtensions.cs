using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeIsExtensions
    {
        /// <summary>
        /// Returns whether the <see cref="T:System.DateTime" /> is the last day of the month.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check is the last day of the month.</param>
        /// <returns>True if the <see cref="T:System.DateTime" /> is the last day of the month; otherwise returns false.</returns>
        public static bool IsLastDayOfTheMonth(this DateTime source)
        {
            return source == new DateTime(source.Year, source.Month, 1).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// Returns whether the <see cref="T:System.DateTime" /> is on a weekend.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check is on a weekend.</param>
        /// <returns>True if the <see cref="T:System.DateTime" /> is on a weekend; otherwise returns false.</returns>
        public static bool IsWeekend(this DateTime source)
        {
            return source.DayOfWeek == DayOfWeek.Saturday || source.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Returns whether the <see cref="T:System.DateTime" /> is on a leap year.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check is on a leap year.</param>
        /// <returns>True if the <see cref="T:System.DateTime" /> is on a leap year; otherwise returns false.</returns>
        public static bool IsLeapYear(this DateTime source)
        {
            return DateTime.IsLeapYear(source.Year);
        }
    }
}