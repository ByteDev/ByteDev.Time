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
            [TestCase(2020, 1, 31)]
            [TestCase(2020, 2, 29)]
            [TestCase(2020, 3, 31)]
            [TestCase(2020, 4, 30)]
            [TestCase(2020, 5, 31)]
            [TestCase(2020, 6, 30)]
            [TestCase(2020, 7, 31)]
            [TestCase(2020, 8, 31)]
            [TestCase(2020, 9, 30)]
            [TestCase(2020, 10, 31)]
            [TestCase(2020, 11, 30)]
            [TestCase(2020, 12, 31)]
            public void WhenDateIsLastDayOfTheMonth_ThenReturnTrue(int year, int month, int day)
            {
                var sut = new DateTime(year, month, day);

                var result = sut.IsLastDayOfTheMonth();

                Assert.That(result, Is.True);
            }

            [TestCase(2020, 1, 30)]
            [TestCase(2020, 1, 1)]
            public void WhenDateIsNotLastDayOfTheMonth_ThenReturnFalse(int year, int month, int day)
            {
                var sut = new DateTime(year, month, day);

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
        public class IsAfter
        {
            [Test]
            public void WhenIsAfterArg_ThenReturnTrue()
            {
                var sut = DateTime.Now;

                var result = sut.IsAfter(sut.AddMilliseconds(-1));

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIsEqualToArg_ThenReturnFalse()
            {
                var sut = DateTime.Now;

                var result = sut.IsAfter(sut);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenIsBeforeArg_ThenReturnFalse()
            {
                var sut = DateTime.Now;

                var result = sut.IsAfter(sut.AddMilliseconds(1));

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsBefore
        {
            [Test]
            public void WhenIsBeforeArg_ThenReturnTrue()
            {
                var sut = DateTime.Now;

                var result = sut.IsBefore(sut.AddMilliseconds(1));

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIsEqualToArg_ThenReturnFalse()
            {
                var sut = DateTime.Now;

                var result = sut.IsBefore(sut);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenIsAfterArg_ThenReturnFalse()
            {
                var sut = DateTime.Now;

                var result = sut.IsBefore(sut.AddMilliseconds(-1));

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsBetween
        {
            [Test]
            public void WhenStartIsAfterEnd_ThenThrowException()
            {
                var sut = new DateTime(2020, 1, 10);

                Assert.Throws<ArgumentException>(() => sut.IsBetween(new DateTime(2020, 1, 5), new DateTime(2020, 1, 4)));
            }


            [Test]
            public void WhenCompareDateTime_AndIsEqualToStartAndEnd_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 1, 10);

                var result = sut.IsBetween(sut, sut);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenCompareDateTime_AndIsBetween_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 1, 10, 12, 0, 0);

                var result = sut.IsBetween(new DateTime(2020, 1, 10, 11, 59, 59), new DateTime(2020, 1, 10, 12, 0, 1));

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenCompareDateTime_AndIsNotBetween_ThenReturnFalse()
            {
                var sut = new DateTime(2020, 1, 10, 12, 0, 0);

                var result = sut.IsBetween(new DateTime(2020, 1, 10, 12, 0, 1), new DateTime(2020, 1, 10, 12, 0, 2));

                Assert.That(result, Is.False);
            }


            [Test]
            public void WhenCompareDateOnly_AndIsEqualToStartAndEnd_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 1, 10);

                var result = sut.IsBetween(sut, sut, false);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenCompareDateOnly_AndIsBetween_ThenReturnTrue()
            {
                var sut = new DateTime(2020, 1, 10);

                var result = sut.IsBetween(new DateTime(2020, 1, 9), new DateTime(2020, 1, 11), false);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenCompareDateOnly_AndIsBetween_ThenReturnFalse()
            {
                var sut = new DateTime(2020, 1, 10);

                var result = sut.IsBetween(new DateTime(2020, 1, 11), new DateTime(2020, 1, 12), false);

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsMonth
        {
            private DateTime _sut;

            [SetUp]
            public void SetUp()
            {
                _sut = new DateTime(2020, 1, 1);
            }

            [Test]
            public void WhenIsMonth_ThenReturnTrue()
            {
                var result = _sut.IsMonth(Month.January);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIsNotMonth_ThenReturnFalse()
            {
                var result = _sut.IsMonth(Month.February);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenMonthIsNotDefined_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _sut.IsMonth((Month)13));
            }
        }
    }
}