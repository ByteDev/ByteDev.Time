using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeTruncateExtensionsTests
    {
        [TestFixture]
        public class TruncateToSecond
        {
            [Test]
            public void WhenMillisecondsSpecified_ThenSetMillisecondsZero()
            {
                var sut = new DateTime(2000, 1, 10, 12, 20, 30, 99);

                var result = sut.TruncateToSecond();

                Assert.That(result.Second, Is.EqualTo(30));
                Assert.That(result.Millisecond, Is.EqualTo(0));
            }
        }

        [TestFixture]
        public class TruncateToMinute
        {
            [Test]
            public void WhenSecondsSpecified_ThenSetSecondsToZero()
            {
                var sut = new DateTime(2000, 1, 10, 12, 20, 30, 99);

                var result = sut.TruncateToMinute();

                Assert.That(result.Minute, Is.EqualTo(20));
                Assert.That(result.Second, Is.EqualTo(0));
                Assert.That(result.Millisecond, Is.EqualTo(0));
            }
        }

        [TestFixture]
        public class TruncateToHour
        {
            [Test]
            public void WhenMinutesSpecified_ThenSetMinutesToZero()
            {
                var sut = new DateTime(2000, 1, 10, 12, 20, 30, 99);

                var result = sut.TruncateToHour();

                Assert.That(result.Hour, Is.EqualTo(12));
                Assert.That(result.Minute, Is.EqualTo(0));
                Assert.That(result.Second, Is.EqualTo(0));
                Assert.That(result.Millisecond, Is.EqualTo(0));
            }
        }
    }
}