using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeToDateTimeOffsetExtensionsTests
    {
        [TestFixture]
        public class ToDateTimeOffset
        {
            private readonly TimeZoneInfo _sgTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");

            [Test]
            public void WhenTimeZoneInfoIsNull_ThenThrowException()
            {
                var sut = DateTime.UtcNow;
                
                Assert.Throws<ArgumentNullException>(() => sut.ToDateTimeOffset(null));
            }

            [Test]
            public void WhenSourceIsNotUtc_ThenThrowException()
            {
                var sut = DateTime.Now;

                Assert.Throws<ArgumentException>(() => sut.ToDateTimeOffset(_sgTimeZoneInfo));
            }

            [Test]
            public void WhenTimeZoneSupplied_ThenReturnDateTimeOffset()
            {
                var sut = DateTime.UtcNow;

                var result = sut.ToDateTimeOffset(_sgTimeZoneInfo);

                Assert.That(result.Offset, Is.EqualTo(new TimeSpan(8, 0, 0)));
            }
        }
    }
}