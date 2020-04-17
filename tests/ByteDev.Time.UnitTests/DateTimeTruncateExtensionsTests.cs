using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeTruncateExtensionsTests
    {
        private DateTime _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new DateTime(2000, 1, 10, 12, 20, 30, 99);
        }

        [TestFixture]
        public class TruncateToDay : DateTimeTruncateExtensionsTests
        {
            [Test]
            public void WhenHoursSpecified_ThenSetHoursToZero()
            {
                var result = _sut.TruncateToDay();

                Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 10)));
            }
        }

        [TestFixture]
        public class TruncateToHour : DateTimeTruncateExtensionsTests
        {
            [Test]
            public void WhenMinutesSpecified_ThenSetMinutesToZero()
            {
                var result = _sut.TruncateToHour();

                Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 10, 12, 0, 0)));
            }
        }

        [TestFixture]
        public class TruncateToMinute : DateTimeTruncateExtensionsTests
        {
            [Test]
            public void WhenSecondsSpecified_ThenSetSecondsToZero()
            {
                var result = _sut.TruncateToMinute();

                Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 10, 12, 20, 0)));
            }
        }

        [TestFixture]
        public class TruncateToSecond : DateTimeTruncateExtensionsTests
        {
            [Test]
            public void WhenMillisecondsSpecified_ThenSetMillisecondsZero()
            {
                var result = _sut.TruncateToSecond();

                Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 10, 12, 20, 30, 0)));
            }
        }
    }
}