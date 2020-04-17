using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Extension methods for <see cref="T:System.DateTime" />.
    /// </summary>
    public static class DateTimeToStringExtensions
    {
        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: Wed 31st December 2014.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDateDayShort(this DateTime source)
        {
            return string.Format("{0:ddd} {1} {0:MMMM yyyy}", source, source.GetDayAsOrdinal());
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: Wednesday 31st December 2014.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDateDayLong(this DateTime source)
        {
            return string.Format("{0:dddd} {1} {0:MMMM yyyy}", source, source.GetDayAsOrdinal());
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: Wed 31st.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringDayOnly(this DateTime source)
        {
            return $"{source:ddd} {source.GetDayAsOrdinal()}";
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: yyyyMMddhhmmss.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringSortable(this DateTime source)
        {
            return ToStringSortable(source, string.Empty);
        }

        /// <summary>
        /// Returns the <see cref="T:System.DateTime" /> in the format: yyyyMMddhhmmss.
        /// </summary>
        /// <param name="source">The <see cref="T:System.DateTime" /> to return as a string.</param>
        /// <param name="delimiter">Delimiter string between <see cref="T:System.DateTime" /> parts.</param>
        /// <returns>String representing the <see cref="T:System.DateTime" />.</returns>
        public static string ToStringSortable(this DateTime source, string delimiter)
        {
            return source.ToString($"yyyy{delimiter}MM{delimiter}dd{delimiter}hh{delimiter}mm{delimiter}ss");
        }

    }
}