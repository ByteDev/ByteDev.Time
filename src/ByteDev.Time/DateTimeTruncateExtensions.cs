using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeTruncateExtensions
    {
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

        private static DateTime Truncate(DateTime source, TimeSpan timeSpan)
        {
            return source.AddTicks(-(source.Ticks % timeSpan.Ticks));
        }
    }
}