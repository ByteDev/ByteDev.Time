using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Provides a way to get <see cref="T:System.DateTimeOffset" /> through an interface.
    /// </summary>
    public class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        /// <summary>
        /// Returns <see cref="T:System.DateTimeOffset" />.Now.
        /// </summary>
        public DateTimeOffset Now => DateTimeOffset.Now;
        
        /// <summary>
        /// Returns <see cref="T:System.DateTimeOffset" />.UtcNow.
        /// </summary>
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}