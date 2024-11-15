using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class TimeSpanExtensionsTests
    {
        [TestFixture]
        public class ToApproxDescription
        {
            [TestCase(1, "1 day")]
            [TestCase(2, "2 days")]
            public void WhenDaysAreGreaterThanZero_ThenReturnDayString(int days, string expected)
            {
                var sut = new TimeSpan(days, 2, 3, 4);

                var result = sut.ToApproxDescription();

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(1, "1 hour")]
            [TestCase(2, "2 hours")]
            public void WhenHoursAreGreaterThanZero_ThenReturnHoursString(int hours, string expected)
            {
                var sut = new TimeSpan(0, hours, 3, 4);

                var result = sut.ToApproxDescription();

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(1, "1 minute")]
            [TestCase(2, "2 minutes")]
            public void WhenMinutesAreGreaterThanZero_ThenReturnMinutesString(int minutes, string expected)
            {
                var sut = new TimeSpan(0, 0, minutes, 4);

                var result = sut.ToApproxDescription();

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(0, "0 seconds")]
            [TestCase(10, "10 seconds")]
            public void WhenSecondsAreGreaterThanZero_ThenReturnSecondsString(int seconds, string expected)
            {
                var sut = new TimeSpan(0, 0, 0, seconds);

                var result = sut.ToApproxDescription();

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(1)]
            [TestCase(9)]
            public void WhenSecondsAreLessThan10_ThenReturnFewSecondsAgoString(int seconds)
            {
                var sut = new TimeSpan(0, 0, 0, seconds);

                var result = sut.ToApproxDescription();

                Assert.That(result, Is.EqualTo("A few seconds"));
            }
        }
    }
}
