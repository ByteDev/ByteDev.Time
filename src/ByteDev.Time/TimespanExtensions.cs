using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.TimeSpan" />.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Returns a text approximate representation of the <see cref="T:System.TimeSpan" />. 
        /// </summary>
        /// <param name="source">The <see cref="T:System.TimeSpan" /> to get the approximate text from.</param>
        /// <returns>A text approximate representation of the <see cref="T:System.TimeSpan" />.</returns>
        public static string ToApproxFormat(this TimeSpan source)
        {
            if (source.Days > 0)
                return source.Days + " day".Pluralize(source.Days);

            if (source.Hours > 0)
                return source.Hours + " hour".Pluralize(source.Hours);

            if (source.Minutes > 0)
                return source.Minutes + " minute".Pluralize(source.Minutes);

            return source.Seconds + " second".Pluralize(source.Seconds);
        }
    }
}
