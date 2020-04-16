using System;
using System.Globalization;

namespace ByteDev.Time
{
    /// <summary>
    /// Representation of a Month.
    /// </summary>
    public class Month
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Time.Month" /> class.
        /// </summary>
        /// <param name="monthNumber">The month number (1 to 12).</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="monthNumber" /> must be between 1 and 12.</exception>
        public Month(int monthNumber)
        {
            if (monthNumber < 1 || monthNumber > 12)
                throw new ArgumentOutOfRangeException(nameof(monthNumber), "Month number must be between 1 and 12.");

            Number = monthNumber;
        }

        /// <summary>
        /// Month number (1 to 12).
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The month full name.
        /// </summary>
        public string Name => CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[Number - 1];

        /// <summary>
        /// Three letter abbreviation of the month name.
        /// </summary>
        public string ShortName => CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames[Number - 1];
    }
}