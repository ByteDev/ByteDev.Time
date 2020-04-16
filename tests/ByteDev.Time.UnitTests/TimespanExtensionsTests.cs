using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class TimespanExtensionsTests
    {
        [TestFixture]
        public class ToApproxFormat
        {
            [Test]
            public void WhenDaysAreGreaterThanZero_ThenReturnDayString()
            {
                var sut = new TimeSpan(1, 2, 3, 4);

                var result = sut.ToApproxFormat();

                Assert.That(result, Is.EqualTo(sut.Days + " day"));
            }

            [Test]
            public void WhenHoursAreGreaterThanZero_ThenReturnHoursString()
            {
                var sut = new TimeSpan(0, 2, 3, 4);

                var result = sut.ToApproxFormat();

                Assert.That(result, Is.EqualTo(sut.Hours + " hours"));
            }

            [Test]
            public void WhenMinutesAreGreaterThanZero_ThenReturnMinutesString()
            {
                var sut = new TimeSpan(0, 0, 3, 4);

                var result = sut.ToApproxFormat();

                Assert.That(result, Is.EqualTo(sut.Minutes + " minutes"));
            }

            [Test]
            public void WhenSecondsAreGreaterThanZero_ThenReturnSecondsString()
            {
                var sut = new TimeSpan(0, 0, 0, 4);

                var result = sut.ToApproxFormat();

                Assert.That(result, Is.EqualTo(sut.Seconds + " seconds"));
            }

            [Test]
            public void WhenSecondsAreZero_ThenReturnSecondsString()
            {
                var sut = new TimeSpan(0, 0, 0, 0, 10);

                var result = sut.ToApproxFormat();

                Assert.That(result, Is.EqualTo(sut.Seconds + " seconds"));
            }
        }
    }
}
