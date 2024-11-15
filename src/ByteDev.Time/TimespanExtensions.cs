using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.TimeSpan" />.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Returns a text approximate description of the <see cref="T:System.TimeSpan" />. 
        /// </summary>
        /// <param name="source">The <see cref="T:System.TimeSpan" /> to get the approximate text from.</param>
        /// <returns>A text approximate description of the <see cref="T:System.TimeSpan" />.</returns>
        public static string ToApproxDescription(this TimeSpan source)
        {
            if (source.Days > 0)
                return source.Days + " day".Pluralize(source.Days);

            if (source.Hours > 0)
                return source.Hours + " hour".Pluralize(source.Hours);

            if (source.Minutes > 0)
                return source.Minutes + " minute".Pluralize(source.Minutes);

            if (source.Seconds < 1 || source.Seconds >= 10)
                return source.Seconds + " second".Pluralize(source.Seconds);

            return "A few seconds";
        }
    }
}
