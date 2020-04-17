using System;

namespace ByteDev.Time
{
    /// <summary>
    /// Represents a range between one <see cref="T:System.DateTime" /> and another.
    /// </summary>
    public class DateTimeRange : IRange<DateTime>
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
        /// Initializes a new instance of the <see cref="T:ByteDev.Time.DateTimeRange" /> class.
        /// </summary>
        /// <param name="start">Start <see cref="T:System.DateTime" /> in the range.</param>
        /// <param name="end">End <see cref="T:System.DateTime" /> in the range.</param>
        /// <exception cref="T:System.ArgumentException">Start must be equal to or before end.</exception>
        public DateTimeRange(DateTime start, DateTime end)
        {
            if (start > end)
                throw new ArgumentException("Start must be equal to or before end.");

            Start = start;
            End = end;
        }

        /// <summary>
        /// Determines if a <see cref="T:System.DateTime" /> is inside the range.
        /// </summary>
        /// <param name="value">The <see cref="T:System.DateTime" /> to check.</param>
        /// <returns>True if <paramref name="value" /> is inside the range; otherwise false.</returns>
        public bool IsInRange(DateTime value)
        {
            return value >= Start && value <= End;
        }

        /// <summary>
        /// Determines if a <see cref="T:System.ByteDev.Time.DateTimeRange" /> is inside the range.
        /// </summary>
        /// <param name="range">The <see cref="T:System.ByteDev.Time.DateTimeRange" /> to check.</param>
        /// <returns>True if <paramref name="range" /> is inside the range; otherwise false.</returns>
        public bool IsInRange(IRange<DateTime> range)
        {
            return range.Start >= Start && range.End <= End;
        }
    }
}