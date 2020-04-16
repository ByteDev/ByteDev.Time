using System;

namespace ByteDev.Time.Providers
{
    /// <summary>
    /// Provides a way to get <see cref="T:System.DateTimeOffset" /> through an interface.
    /// </summary>
    public interface IDateTimeOffsetProvider
    {
        /// <summary>
        /// Returns <see cref="T:System.DateTimeOffset" />.Now.
        /// </summary>
        DateTimeOffset Now { get; }

        /// <summary>
        /// Returns <see cref="T:System.DateTimeOffset" />.UtcNow.
        /// </summary>
        DateTimeOffset UtcNow { get; }
    }
}