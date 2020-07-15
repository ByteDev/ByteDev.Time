using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
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
        public class MonthLength
        {
            [Test]
            public void WhenIsJan_ThenReturnLastDay()
            {
                var sut = new DateTime(2020, 1, 1);

                var result = sut.MonthLength();

                Assert.That(result, Is.EqualTo(31));
            }

            [Test]
            public void WhenIsFebInLeapYear_ThenReturnLastDay()
            {
                var sut = new DateTime(2020, 2, 1);
                
                var result = sut.MonthLength();

                Assert.That(result, Is.EqualTo(29));
            }
        }

        [TestFixture]
        public class WithYear
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewYear()
            {
                var expected = new DateTime(2021, 1, 2, 23, 59, 30);

                var sut = new DateTime(2020, 1, 2, 23, 59, 30);

                var result = sut.WithYear(expected.Year);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithMonth
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewMonth()
            {
                var expected = new DateTime(2020, 10, 2, 23, 59, 30);

                var sut = new DateTime(2020, 1, 2, 23, 59, 30);

                var result = sut.WithMonth(expected.Month);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithDay
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewDay()
            {
                var expected = new DateTime(2020, 1, 10, 23, 59, 30);

                var sut = new DateTime(2020, 1, 2, 23, 59, 30);

                var result = sut.WithDay(expected.Day);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithHour
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewHour()
            {
                var expected = new DateTime(2020, 1, 10, 10, 59, 30);

                var sut = new DateTime(2020, 1, 10, 23, 59, 30);

                var result = sut.WithHour(expected.Hour);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithMinute
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewMinute()
            {
                var expected = new DateTime(2020, 1, 10, 10, 59, 30);

                var sut = new DateTime(2020, 1, 10, 10, 10, 30);

                var result = sut.WithMinute(expected.Minute);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithSecond
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewSecond()
            {
                var expected = new DateTime(2020, 1, 10, 20, 30, 40);

                var sut = new DateTime(2020, 1, 10, 20, 30, 30);

                var result = sut.WithSecond(expected.Second);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class WithMillisecond
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewMillisecond()
            {
                var expected = new DateTime(2020, 1, 10, 20, 30, 40, 500);

                var sut = new DateTime(2020, 1, 10, 20, 30, 40, 999);

                var result = sut.WithMillisecond(expected.Millisecond);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class EndOfDay
        {
            [Test]
            public void WhenCalled_ThenReturnsEndOfDay()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);
                
                var result = sut.EndOfDay();
                
                Assert.That(result, Is.EqualTo(new DateTime(2020, 6, 13, TimeMax.Hours, TimeMax.Minutes, TimeMax.Seconds, TimeMax.Milliseconds)));
            }
        }

        [TestFixture]
        public class EndOfMonth
        {
            [Test]
            public void WhenCalled_ThenReturnsEndOfMonth()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);

                var result = sut.EndOfMonth();
                
                Assert.That(result, Is.EqualTo(new DateTime(2020, 6, 30, TimeMax.Hours, TimeMax.Minutes, TimeMax.Seconds, TimeMax.Milliseconds)));
            }
        }

        [TestFixture]
        public class EndOfYear
        {
            [Test]
            public void WhenCalled_ThenReturnsEndOfDay()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);
                
                var result = sut.EndOfYear();
                
                Assert.That(result, Is.EqualTo(new DateTime(2020, 12, 31, TimeMax.Hours, TimeMax.Minutes, TimeMax.Seconds, TimeMax.Milliseconds)));
            }
        }

        [TestFixture]
        public class EqualsDate
        {
            [Test]
            public void WhenDateIsEqual_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);

                var result = sut.EqualsDate(new DateTime(sut.Year, sut.Month, sut.Day, sut.Hour + 1, sut.Minute + 1, sut.Second + 1, sut.Millisecond + 1));

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenDateIsNotEqual_ThenReturnFalse()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);

                var result = sut.EqualsDate(sut.WithDay(sut.Day + 1));

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class EqualsTime
        {
            [Test]
            public void WhenTimeIsEqual_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);

                var result = sut.EqualsTime(new DateTime(sut.Year + 1, sut.Month + 1, sut.Day + 1, sut.Hour, sut.Minute, sut.Second, sut.Millisecond));

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenTimeIsNotEqual_ThenReturnFalse()
            {
                var sut = new DateTime(2020, 6, 13, 10, 20, 30, 500);

                var result = sut.EqualsTime(sut.WithMillisecond(sut.Millisecond + 1));

                Assert.That(result, Is.False);
            }
        }
    }
}
