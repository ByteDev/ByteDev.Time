using System;

namespace ByteDev.Time
{
    public static class DateTimeToDateTimeOffsetExtensions
    {
        /// <summary>
        /// Returns a new DateTimeOffset for a UTC set DateTime applying the provided TimeZoneInfo.
        /// </summary>
        /// <param name="source">UTC set DateTime.</param>
        /// <param name="timeZoneInfo">TimeZoneInfo to apply when creating the DateTimeOffset.</param>
        /// <returns>DateTimeOffset using the provided UTC set DateTime and TimeZoneInfo.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="timeZoneInfo" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="source" /> is not in UTC time.</exception>
        public static DateTimeOffset ToDateTimeOffset(this DateTime source, TimeZoneInfo timeZoneInfo)
        {
            if (timeZoneInfo == null)
                throw new ArgumentNullException(nameof(timeZoneInfo));

            if (!source.IsUtc())
                throw new ArgumentException("Is not UTC time.", nameof(source));
            
            var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(source, timeZoneInfo);

            return new DateTimeOffset(localDateTime, timeZoneInfo.GetUtcOffset(localDateTime));
        }
    }
}