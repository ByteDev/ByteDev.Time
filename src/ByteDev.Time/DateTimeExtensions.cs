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
        /// Returns the days in the month.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to use.</param>
        /// <returns>Number of days in the month of <paramref name="source" />.</returns>
        public static int MonthLength(this DateTime source)
        {
            return DateTime.DaysInMonth(source.Year, source.Month);
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> based on <paramref name="source" /> with the
        /// time set to the last moment of the day.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to perform the operation on.</param>
        /// <returns>Date time set to the last moment of the day.</returns>
        public static DateTime EndOfDay(this DateTime source)
        {
            return source
                .Date
                .AddDays(1)
                .SubtractMillseconds(1);
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
                .SubtractMillseconds(1);
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
    }
}
