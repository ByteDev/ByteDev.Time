using System;

namespace ByteDev.Time.Providers
{
    /// <summary>
    /// Provides a way to get <see cref="T:System.DateTime" /> through an interface.
    /// </summary>
    public class DateTimeProvider : IDateTimeProvider
    {
        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Now.
        /// </summary>
        public DateTime Now => DateTime.Now;

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Today.
        /// </summary>
        public DateTime Today => DateTime.Today;

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.UtcNow.
        /// </summary>
        public DateTime UtcNow => DateTime.UtcNow;

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Now for the provided Time Zone.
        /// </summary>
        /// <param name="timeZoneId">Time Zone ID</param>
        /// <returns>DateTime now for the provided Time Zone.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="timeZoneId" /> is null.</exception>
        /// <exception cref="T:System.TimeZoneNotFoundException">Time Zone not found.</exception>
        public DateTime NowByTimeZoneId(string timeZoneId)
        {
            if (timeZoneId == null)
                throw new ArgumentNullException(nameof(timeZoneId));

            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
        }
    }
}