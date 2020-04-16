using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeIsExtensionsTests
    {
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
    }
}