using System;
using ByteDev.Time.Providers;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests.Providers
{
    [TestFixture]
    public class DateTimeProviderTests
    {
        private DateTimeProvider _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new DateTimeProvider();
        }

        [TestFixture]
        public class NowByTimeZoneId : DateTimeProviderTests
        {
            [Test]
            public void WhenTimeZoneIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => _ = _sut.NowByTimeZoneId(null));
            }

            [TestCase("")]
            [TestCase("Nowhere Standard Time")]
            public void WhenTimeZoneIsInvalid_ThenThrowException(string timeZoneId)
            {
                Assert.Throws<TimeZoneNotFoundException>(() => _ = _sut.NowByTimeZoneId(timeZoneId));
            }

            [Test]
            public void WhenTimeZoneIsValid_ThenReturnTime()
            {
                var result1 = _sut.NowByTimeZoneId("Singapore Standard Time");
                var result2 = _sut.NowByTimeZoneId("Central Standard Time");

                Assert.That(result1, Is.Not.EqualTo(result2));
            }
        }
    }
}