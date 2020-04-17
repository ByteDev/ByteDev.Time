using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeSubtractExtensionsTests
    {
        [TestFixture]
        public class SubtractYears
        {
            [Test]
            public void WhenOneYear_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17).SubtractYears(1);

                Assert.That(result, Is.EqualTo(new DateTime(1999, 6, 17)));
            }
        }

        [TestFixture]
        public class SubtractMonths
        {
            [Test]
            public void WhenOneMonth_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17).SubtractMonths(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 5, 17)));
            }
        }

        [TestFixture]
        public class SubtractWeeks
        {
            [Test]
            public void WhenOneWeek_ThenSubtractOneWeekFromDate()
            {
                var result = new DateTime(2000, 6, 17).SubtractWeeks(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 10)));
            }
        }

        [TestFixture]
        public class SubtractDays
        {
            [Test]
            public void WhenOneDay_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17).SubtractDays(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 16)));
            }
        }

        [TestFixture]
        public class SubtractHours
        {
            [Test]
            public void WhenOneHour_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17, 12, 0, 0).SubtractHours(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 17, 11, 0, 0)));
            }
        }

        [TestFixture]
        public class SubtractMinutes
        {
            [Test]
            public void WhenOneMinute_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17, 12, 30, 0).SubtractMinutes(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 17, 12, 29, 0)));
            }
        }

        [TestFixture]
        public class SubtractSeconds
        {
            [Test]
            public void WhenOneSecond_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17, 12, 30, 45).SubtractSeconds(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 17, 12, 30, 44)));
            }
        }

        [TestFixture]
        public class SubtractMilliseconds
        {
            [Test]
            public void WhenOneMillisecond_ThenReturnDateTime()
            {
                var result = new DateTime(2000, 6, 17, 12, 30, 45, 500).SubtractMillseconds(1);

                Assert.That(result, Is.EqualTo(new DateTime(2000, 6, 17, 12, 30, 45, 499)));
            }
        }
    }
}