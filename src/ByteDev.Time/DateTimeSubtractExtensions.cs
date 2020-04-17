using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeSubtractExtensions
    {
        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of years.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of years.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of years subtracted.</returns>
        public static DateTime SubtractYears(this DateTime source, int value)
        {
            return source.AddYears(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of months.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of months.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of months subtracted.</returns>
        public static DateTime SubtractMonths(this DateTime source, int value)
        {
            return source.AddMonths(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of weeks.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of weeks.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of weeks subtracted.</returns>
        public static DateTime SubtractWeeks(this DateTime source, int value)
        {
            return source.AddWeeks(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of days.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of days.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of days subtracted.</returns>
        public static DateTime SubtractDays(this DateTime source, int value)
        {
            return source.AddDays(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of hours.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of hours.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of hours subtracted.</returns>
        public static DateTime SubtractHours(this DateTime source, int value)
        {
            return source.AddHours(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of minutes.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of minutes.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of minutes subtracted.</returns>
        public static DateTime SubtractMinutes(this DateTime source, int value)
        {
            return source.AddMinutes(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of seconds.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of seconds.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of seconds subtracted.</returns>
        public static DateTime SubtractSeconds(this DateTime source, int value)
        {
            return source.AddSeconds(value * -1);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> resulting from subtracting the given number of milliseconds.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract from.</param>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>New <see cref="T:System.DateTime" /> with the number of milliseconds subtracted.</returns>
        public static DateTime SubtractMillseconds(this DateTime source, int value)
        {
            return source.AddMilliseconds(value * -1);
        }
    }
}