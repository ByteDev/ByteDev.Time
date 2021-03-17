using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Represents a year.
    /// </summary>
    public readonly struct Year
    {
        /// <summary>
        /// Indicates if the year is a leap year or not. If year is less than one or
        /// greater than 9999 will always returns false.
        /// </summary>
        public bool IsLeap { get; }

        /// <summary>
        /// The millennium part of the year.
        /// </summary>
        public int Millennium { get; }

        /// <summary>
        /// The century part of the year.
        /// </summary>
        public int Century { get; }

        /// <summary>
        /// The decade part of the year.
        /// </summary>
        public int Decade { get; }

        /// <summary>
        /// Year value.
        /// </summary>
        public int Value { get; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Time.Year" /> struct.
        /// </summary>
        /// <param name="year">Year as an integer</param>
        public Year(int year)
        {
            IsLeap = year > 0 && year < 10000 && DateTime.IsLeapYear(year);
            Value = year;
            Century = year / 100;
            Millennium = year / 1000;

            if (year > -10 && year < 10)
            {
                Decade = 0;
            }
            else
            {
                var yearStr = year.ToString();

                Decade = int.Parse(yearStr.Substring(yearStr.Length - 2));
            }
        }

        /// <summary>
        /// Returns a representation of the year as a string.
        /// </summary>
        /// <returns>Year value as a string.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}