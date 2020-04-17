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
        /// Returns a new <see cref="T:System.DateTime" /> with the number of weeks subtracted.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to subtract the weeks from.</param>
        /// <param name="numberOfWeeks">Number of weeks to subtract.</param>
        /// <returns>The new <see cref="T:System.DateTime" /> with the number of weeks subtracted.</returns>
        public static DateTime SubtractWeeks(this DateTime source, int numberOfWeeks)
        {
            return source.AddDays(-1 * DaysInWeek * numberOfWeeks);
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
        /// <param name="source">Base <see cref="T:System.DateTime" />.</param>
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
        /// <param name="source">Base <see cref="T:System.DateTime" />.</param>
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
        /// <param name="source">Base <see cref="T:System.DateTime" />.</param>
        /// <param name="day">Value to set day to on the new <see cref="T:System.DateTime" />.</param>
        /// <returns>The new <see cref="T:System.DateTime" />.</returns>
        public static DateTime WithDay(this DateTime source, int day)
        {
            return new DateTime(source.Year, source.Month, day, source.Hour, source.Minute, source.Second, source.Millisecond);
        }
    }
}
