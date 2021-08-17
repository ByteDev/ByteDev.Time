using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeWithExtensions
    {
        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with date
        /// set from <paramref name="date" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="date">Value to set date to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithDate(this DateTime source, DateTime date)
        {
            return WithDate(source, date.Year, date.Month, date.Day);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with date
        /// set from <paramref name="year" />, <paramref name="month" /> and <paramref name="day" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="year">Year to set on the new <see cref="T:System.DateTime" />.</param>
        /// <param name="month">Month to set on the new <see cref="T:System.DateTime" />.</param>
        /// <param name="day">Day to set on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithDate(this DateTime source, int year, int month, int day)
        {
            return new DateTime(year, month, day, source.Hour, source.Minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with time
        /// set from <paramref name="time" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="time">Value to set time to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithTime(this DateTime source, DateTime time)
        {
            return WithTime(source, time.Hour, time.Minute, time.Second, time.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with time
        /// set from <paramref name="hour" />, <paramref name="minute" />,  <paramref name="second" /> and <paramref name="millisecond" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="hour">Hour to set on the new <see cref="T:System.DateTime" />.</param>
        /// <param name="minute">Minute to set on the new <see cref="T:System.DateTime" />.</param>
        /// <param name="second">Second to set on the new <see cref="T:System.DateTime" />.</param>
        /// <param name="millisecond">Millisecond to set on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithTime(this DateTime source, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(source.Year, source.Month, source.Day, hour, minute, second, millisecond);
        }
        
        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with year
        /// set to <paramref name="year" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="year">Value to set year to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithYear(this DateTime source, int year)
        {
            return new DateTime(year, source.Month, source.Day, source.Hour, source.Minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with month
        /// set to <paramref name="month" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="month">Value to set month to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithMonth(this DateTime source, int month)
        {
            return new DateTime(source.Year, month, source.Day, source.Hour, source.Minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with day
        /// set to <paramref name="day" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="day">Value to set day to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithDay(this DateTime source, int day)
        {
            return new DateTime(source.Year, source.Month, day, source.Hour, source.Minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with hour
        /// set to <paramref name="hour" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="hour">Value to set hour to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithHour(this DateTime source, int hour)
        {
            return new DateTime(source.Year, source.Month, source.Day, hour, source.Minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with minute
        /// set to <paramref name="minute" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="minute">Value to set minute to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithMinute(this DateTime source, int minute)
        {
            return new DateTime(source.Year, source.Month, source.Day, source.Hour, minute, source.Second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with second
        /// set to <paramref name="second" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="second">Value to set second to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithSecond(this DateTime source, int second)
        {
            return new DateTime(source.Year, source.Month, source.Day, source.Hour, source.Minute, second, source.Millisecond);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with millisecond
        /// set to <paramref name="millisecond" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="millisecond">Value to set millisecond to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithMillisecond(this DateTime source, int millisecond)
        {
            return new DateTime(source.Year, source.Month, source.Day, source.Hour, source.Minute, source.Second, millisecond);
        }
    }
}