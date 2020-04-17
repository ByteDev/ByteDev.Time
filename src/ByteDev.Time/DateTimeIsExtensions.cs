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
        /// Determines if <paramref name="source" /> is between <paramref name="startDateTime" /> and <paramref name="endDateTime" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to check.</param>
        /// <param name="startDateTime">The start <see cref="T:System.DateTime" />.</param>
        /// <param name="endDateTime">The end <see cref="T:System.DateTime" />.</param>
        /// <param name="compareTime">True compares the full date time; False compares only the date part.</param>
        /// <returns>True if <paramref name="source" /> is between; otherwise returns false.</returns>
        public static bool IsBetween(this DateTime source, DateTime startDateTime, DateTime endDateTime, bool compareTime = true)
        {
            if (startDateTime > endDateTime)
            {
                throw new ArgumentException("End must be equal to or before start.");
            }

            if (compareTime)
            {
                return source >= startDateTime && source <= endDateTime;
            }
            
            return source.Date >= startDateTime.Date && source.Date <= endDateTime.Date;
        }
    }
}