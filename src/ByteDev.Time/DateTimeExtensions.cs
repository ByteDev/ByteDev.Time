using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeExtensions
    {
        private const int DaysInWeek = 7;
        
        /// <summary>
        /// Returns the day as an ordinal. For example 1st, 2nd, 3rd...
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> day to return as an ordinal.</param>
        /// <returns>Day of the month as an ordinal.</returns>
        public static string GetDayAsOrdinal(this DateTime source)
        {
            switch (source.Day)
            {
                case 1:
                case 21:
                case 31:
                    return $"{source.Day}st";
                case 2:
                case 22:
                    return $"{source.Day}nd";
                case 3:
                case 23:
                    return $"{source.Day}rd";
                default:
                    return $"{source.Day}th";
            }
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> with the number of weeks added.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to add the weeks to.</param>
        /// <param name="numberOfWeeks">Number of weeks to add.</param>
        /// <returns>The new <see cref="T:System.DateTime" /> with the number of weeks added.</returns>
        public static DateTime AddWeeks(this DateTime source, int numberOfWeeks)
        {
            return source.AddDays(DaysInWeek * numberOfWeeks);
        }

        /// <summary>
        /// Returns the days in the curren month.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to use.</param>
        /// <returns>Number of days in the month of <paramref name="source" />.</returns>
        public static int MonthLength(this DateTime source)
        {
            return DateTime.DaysInMonth(source.Year, source.Month);
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
        
        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with the
        /// time set to the last moment of the day.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <returns>Date time set to the last moment of the day.</returns>
        public static DateTime EndOfDay(this DateTime source)
        {
            return source.Date
                .AddDays(1)
                .Subtract(CreateMillisecond());
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with the
        /// time set to the last moment of the month.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <returns>Date time set to the last moment of the month.</returns>
        public static DateTime EndOfMonth(this DateTime source)
        {
            return new DateTime(source.Year, source.Month, 1)
                .AddMonths(1)
                .Subtract(CreateMillisecond());
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with the
        /// time set to the last moment of the year.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <returns>Date time set to the last moment of the year.</returns>
        public static DateTime EndOfYear(this DateTime source)
        {
            return new DateTime(source.Year, 12, 31, 23, 59, 59, 999);
        }

        /// <summary>
        /// Determines if the date part of <paramref name="date" /> is equal
        /// to <paramref name="source" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="date">The date to compare.</param>
        /// <returns>True the date parts are equal; otherwise false.</returns>
        public static bool EqualsDate(this DateTime source, DateTime date)
        {
            return source.Date == date.Date;
        }

        /// <summary>
        /// Determines if the time part of <paramref name="time" /> is equal
        /// to <paramref name="source" />.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <param name="time">The time to compare.</param>
        /// <returns>True the time parts are equal; otherwise false.</returns>
        public static bool EqualsTime(this DateTime source, DateTime time)
        {
            return source.Hour == time.Hour &&
                   source.Minute == time.Minute &&
                   source.Second == time.Second &&
                   source.Millisecond == time.Millisecond;
        }

        private static TimeSpan CreateMillisecond()
        {
            return new TimeSpan(0, 0, 0, 0, 1);
        }
    }
}
