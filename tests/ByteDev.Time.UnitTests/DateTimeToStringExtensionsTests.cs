using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeToStringExtensionsTests
    {
        [TestFixture]
        public class ToStringSortable
        {
            [Test]
            public void WhenNoDelimiter_ThenReturnNonDelimitedString()
            {
                var sut = new DateTime(2010, 2, 1, 9, 5, 1);

                var result = sut.ToStringSortable();

                Assert.That(result, Is.EqualTo("20100201090501"));
            }

            [Test]
            public void WhenDelimiterProvided_ThenReturnDelimitedString()
            {
                var sut = new DateTime(2010, 2, 1, 9, 5, 1);

                var result = sut.ToStringSortable("-");

                Assert.That(result, Is.EqualTo("2010-02-01-09-05-01"));
            }
        }

        [TestFixture]
        public class ToStringDateDayShort
        {
            [Test]
            public void WhenDateTime_ThenReturnShortStringVersion()
            {
                var sut = new DateTime(2014, 12, 31, 12, 15, 30);

                var result = sut.ToStringDateDayShort();

                Assert.That(result, Is.EqualTo("Wed 31st December 2014"));
            } 
        }

        [TestFixture]
        public class ToStringDateDayLong
        {
            [Test]
            public void WhenDateTime_ThenReturnLongVersion()
            {
                var sut = new DateTime(2014, 12, 31, 12, 15, 30);

                var result = sut.ToStringDateDayLong();

                Assert.That(result, Is.EqualTo("Wednesday 31st December 2014"));
            } 
        }

        [TestFixture]
        public class ToStringDayOnly
        {
            [Test]
            public void WhenDateTime_ThenReturnDateDayVersion()
            {
                var sut = new DateTime(2014, 12, 31, 12, 15, 30);

                var result = sut.ToStringDayOnly();

                Assert.That(result, Is.EqualTo("Wed 31st"));
            } 
        }
    }
}