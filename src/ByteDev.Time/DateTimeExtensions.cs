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
        /// Returns a new <see cref="T:System.DateTime" /> truncated to the second.
        /// Any milliseconds will be set to zero. 
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to truncate.</param>
        /// <returns>New <see cref="T:System.DateTime" /> truncated to the second.</returns>
        public static DateTime TruncateToSecond(this DateTime source)
        {
            return Truncate(source, TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> truncated to the minute.
        /// Any seconds and milliseconds will be set to zero. 
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to truncate.</param>
        /// <returns>New <see cref="T:System.DateTime" /> truncated to the minute.</returns>
        public static DateTime TruncateToMinute(this DateTime source)
        {
            return Truncate(source, TimeSpan.FromMinutes(1));
        }

        /// <summary>
        /// Returns a new <see cref="T:System.DateTime" /> truncated to the hour.
        /// Any minutes, seconds and milliseconds will be set to zero. 
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to truncate.</param>
        /// <returns>New <see cref="T:System.DateTime" /> truncated to the hour.</returns>
        public static DateTime TruncateToHour(this DateTime source)
        {
            return Truncate(source, TimeSpan.FromHours(1));
        }

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
        /// Returns the <see cref="T:System.DateTime" /> in the example format: Wed 31st December 2014.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDateDayShort(this DateTime source)
        {
            return string.Format("{0:ddd} {1} {0:MMMM yyyy}", source, GetDayAsOrdinal(source));
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: Wednesday 31st December 2014.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDateDayLong(this DateTime source)
        {
            return string.Format("{0:dddd} {1} {0:MMMM yyyy}", source, GetDayAsOrdinal(source));
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: Wed 31st.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDayOnly(this DateTime source)
        {
            return $"{source:ddd} {GetDayAsOrdinal(source)}";
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in a sortable format.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringSortable(this DateTime source)
        {
            return ToStringSortable(source, string.Empty);
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in a sortable format.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <param name="delimiter">Optional delimiter string between <see cref="T:System.DateTime" /> parts.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringSortable(this DateTime source, string delimiter)
        {
            return source.ToString($"yyyy{delimiter}MM{delimiter}dd{delimiter}hh{delimiter}mm{delimiter}ss");
        }

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

        private static DateTime Truncate(DateTime source, TimeSpan timeSpan)
        {
            return source.AddTicks(-(source.Ticks % timeSpan.Ticks));
        }
    }
}
