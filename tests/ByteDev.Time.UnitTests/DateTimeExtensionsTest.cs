using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeExtensionsTest
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

        [TestFixture]
        public class GetDayAsOrdinal
        {
            [Test]
            [TestCase(1, "st")]
            [TestCase(2, "nd")]
            [TestCase(3, "rd")]
            [TestCase(4, "th")]
            [TestCase(5, "th")]
            [TestCase(6, "th")]
            [TestCase(7, "th")]
            [TestCase(8, "th")]
            [TestCase(9, "th")]
            [TestCase(10, "th")]
            [TestCase(11, "th")]
            [TestCase(12, "th")]
            [TestCase(13, "th")]
            [TestCase(14, "th")]
            [TestCase(15, "th")]
            [TestCase(16, "th")]
            [TestCase(17, "th")]
            [TestCase(18, "th")]
            [TestCase(19, "th")]
            [TestCase(20, "th")]
            [TestCase(21, "st")]
            [TestCase(22, "nd")]
            [TestCase(23, "rd")]
            [TestCase(24, "th")]
            [TestCase(25, "th")]
            [TestCase(26, "th")]
            [TestCase(27, "th")]
            [TestCase(28, "th")]
            [TestCase(29, "th")]
            [TestCase(30, "th")]
            [TestCase(31, "st")]
            public void WhenDayProvided_ThenReturnCorrectSuffix(int day, string expectedSuffix)
            {
                var sut = new DateTime(2000, 1, day);

                var result = sut.GetDayAsOrdinal();

                Assert.That(result, Is.EqualTo($"{day}{expectedSuffix}"));
            }
        }

        [TestFixture]
        public class SubtractWeeks
        {
            [Test]
            public void WhenWeeksIsOne_ThenSubtractOneWeekFromDate()
            {
                var expected = new DateTime(2000, 1, 10);
                var sut = new DateTime(2000, 1, 17);

                var result = sut.SubtractWeeks(1);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class AddWeeks
        {
            [Test]
            public void WhenWeeksIsOne_ThenAddOneWeekFromDate()
            {
                var expected = new DateTime(2000, 1, 24);
                var sut = new DateTime(2000, 1, 17);

                var result = sut.AddWeeks(1);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

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
        public class IsLastDayOfTheMonth
        {
            [Test]
            public void WhenDateIsLastDayOfTheMonth_ThenReturnTrue()
            {
                var sut = new DateTime(2014, 10, 31);

                var result = sut.IsLastDayOfTheMonth();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenDateIsNotLastDayOfTheMonth_ThenReturnFalse()
            {
                var sut = new DateTime(2014, 10, 30);

                var result = sut.IsLastDayOfTheMonth();

                Assert.That(result, Is.False);
            } 
        }

        [TestFixture]
        public class IsLeapYear
        {
            [Test]
            public void WhenIsLeapYear_ThenReturnTrue()
            {
                var sut = new DateTime(2016, 1, 1);

                var result = sut.IsLeapYear();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIsNotLeapYear_ThenReturnFalse()
            {
                var sut = new DateTime(2015, 1, 1);

                var result = sut.IsLeapYear();

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsWeekend
        {
            [Test]
            public void WhenDateIsWeekend_ThenReturnTrue()
            {
                var sut = new DateTime(2014, 11, 1);

                var result = sut.IsWeekend();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenDateIsNotWeekend_ThenReturnFalse()
            {
                var sut = new DateTime(2014, 10, 31);

                var result = sut.IsWeekend();

                Assert.That(result, Is.False);
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
