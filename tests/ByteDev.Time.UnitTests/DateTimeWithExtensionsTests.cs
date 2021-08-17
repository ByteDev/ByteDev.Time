using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeWithExtensionsTests
    {
        [TestFixture]
        public class WithDate : DateTimeWithExtensionsTests
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewDate()
            {
                var sut = new DateTime(2020, 1, 2, 23, 59, 30, 500);

                var result = sut.WithDate(new DateTime(2021, 10, 11));

                Assert.That(result, Is.EqualTo(new DateTime(2021, 10, 11, 23, 59, 30, 500)));
            }
        }

        [TestFixture]
        public class WithTime : DateTimeWithExtensionsTests
        {
            [Test]
            public void WhenCalled_ThenReturnsWithNewDate()
            {
                var sut = new DateTime(2020, 1, 2, 23, 59, 30, 500);

                var result = sut.WithTime(new DateTime(2021, 10, 11, 12, 15, 50, 100));

                Assert.That(result, Is.EqualTo(new DateTime(2020, 1, 2, 12, 15, 50, 100)));
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
    }
}