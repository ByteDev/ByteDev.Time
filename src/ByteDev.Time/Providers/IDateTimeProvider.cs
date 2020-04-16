using System;

namespace ByteDev.Time.Providers
{
    /// <summary>
    /// Provides a way to get <see cref="T:System.DateTime" /> through an interface.
    /// </summary>
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
    }
}