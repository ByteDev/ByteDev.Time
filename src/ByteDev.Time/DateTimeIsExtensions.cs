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
            return source.Day == source.MonthLength();
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

        /// <summary>
        /// Determines if <paramref name="source" /> is after <paramref name="dateTime" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check if after.</param>
        /// <param name="dateTime">The after <see cref="T:System.DateTime" />.</param>
        /// <returns>True if <paramref name="dateTime" /> is after; otherwise returns false.</returns>
        public static bool IsAfter(this DateTime source, DateTime dateTime)
        {
            return source > dateTime;
        }

        /// <summary>
        /// Determines if <paramref name="source" /> is before <paramref name="dateTime" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check if before.</param>
        /// <param name="dateTime">The before <see cref="T:System.DateTime" />.</param>
        /// <returns>True if <paramref name="dateTime" /> is before; otherwise returns false.</returns>
        public static bool IsBefore(this DateTime source, DateTime dateTime)
        {
            return source < dateTime;
        }

        /// <summary>
        /// Determines if <paramref name="source" /> is between <paramref name="start" /> and <paramref name="end" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check.</param>
        /// <param name="start">The start <see cref="T:System.DateTime" />.</param>
        /// <param name="end">The end <see cref="T:System.DateTime" />.</param>
        /// <param name="ignoreTimePart">True compares only the date part; otherwise compares the full date time.</param>
        /// <returns>True if <paramref name="source" /> is between; otherwise returns false.</returns>
        /// <exception cref="T:System.ArgumentException">Start must be equal to or before end.</exception>
        public static bool IsBetween(this DateTime source, DateTime start, DateTime end, bool ignoreTimePart = false)
        {
            if (ignoreTimePart)
                return new DateRange(start, end).IsInRange(source);
  
            return new DateTimeRange(start, end).IsInRange(source);
        }

        /// <summary>
        /// Determines if <paramref name="source" /> is a particular month.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check.</param>
        /// <param name="month">Month to check.</param>
        /// <returns>True if is the <paramref name="month" />; otherwise returns false.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="month" /> is not defined.</exception>
        public static bool IsMonth(this DateTime source, Month month)
        {
            if (!Enum.IsDefined(typeof(Month), month))
                throw new ArgumentException($"No {typeof(Month)} defined for value: '{month}'.", nameof(month));

            return source.Month == (int) month;
        }

        /// <summary>
        /// Determines if <paramref name="source" /> is set to a UTC date time.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check.</param>
        /// <returns>True if UTC; otherwise false.</returns>
        public static bool IsUtc(this DateTime source)
        {
            return source.Kind == DateTimeKind.Utc;
        }
    }
}