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
    }
}