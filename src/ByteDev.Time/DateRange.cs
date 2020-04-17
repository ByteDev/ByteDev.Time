using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Represents a range between one <see cref="T:System.DateTime" /> and another
    /// ignoring the time part.
    /// </summary>
    public class DateRange : IRange<DateTime>
    {
        /// <summary>
        /// Start <see cref="T:System.DateTime" /> in the range.
        /// </summary>
        public DateTime Start { get; }

        /// <summary>
        /// End <see cref="T:System.DateTime" /> in the range.
        /// </summary>
        public DateTime End { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Time.DateRange" /> class.
        /// </summary>
        /// <param name="start">Start <see cref="T:System.DateTime" /> in the range. Time part is ignored.</param>
        /// <param name="end">End <see cref="T:System.DateTime" /> in the range. Time part is ignored.</param>
        /// <exception cref="T:System.ArgumentException">Start must be equal to or before end.</exception>
        public DateRange(DateTime start, DateTime end)
        {
            if (start.Date > end.Date)
                throw new ArgumentException("Start must be equal to or before end.");

            Start = start.Date;
            End = end.Date;
        }

        /// <summary>
        /// Determines if a <see cref="T:System.DateTime" /> is inside the range.
        /// Time part is ignored.
        /// </summary>
        /// <param name="value">The <see cref="T:System.DateTime" /> to check. Time part is ignored.</param>
        /// <returns>True if <paramref name="value" /> is inside the range; otherwise false.</returns>
        public bool IsInRange(DateTime value)
        {
            return value.Date >= Start.Date && value.Date <= End.Date;            
        }

        /// <summary>
        /// Determines if a <see cref="T:System.ByteDev.Time.DateTimeRange" /> is inside the range.
        /// Time parts are ignored.
        /// </summary>
        /// <param name="range">The <see cref="T:System.ByteDev.Time.DateTimeRange" /> to check.</param>
        /// <returns>True if <paramref name="range" /> is inside the range; otherwise false.</returns>
        public bool IsInRange(IRange<DateTime> range)
        {
            return range.Start.Date >= Start.Date && range.End.Date <= End.Date;
        }
    }
}