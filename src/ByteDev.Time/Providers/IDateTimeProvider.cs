using System;

namespace ByteDev.Time.Providers
{
    public interface IDateTimeProvider
    {
        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Now.
        /// </summary>
        DateTime Now { get; }

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Today.
        /// </summary>
        DateTime Today { get; }

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.UtcNow.
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        /// Returns <see cref="T:System.DateTime" />.Now for the provided Time Zone.
        /// </summary>
        /// <param name="timeZoneId">Time Zone ID</param>
        /// <returns>DateTime now for the provided Time Zone.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="timeZoneId" /> is null.</exception>
        /// <exception cref="T:System.TimeZoneNotFoundException">Time Zone not found.</exception>
        DateTime NowByTimeZoneId(string timeZoneId);
    }
}