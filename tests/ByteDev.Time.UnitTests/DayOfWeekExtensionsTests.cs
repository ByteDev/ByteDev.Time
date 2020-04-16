using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DayOfWeekExtensionsTests
    {
        [TestFixture]
        public class ToStringShort
        {
            [TestCase(DayOfWeek.Monday, "Mon")]
            [TestCase(DayOfWeek.Tuesday, "Tue")]
            [TestCase(DayOfWeek.Wednesday, "Wed")]
            [TestCase(DayOfWeek.Thursday, "Thu")]
            [TestCase(DayOfWeek.Friday, "Fri")]
            [TestCase(DayOfWeek.Saturday, "Sat")]
            [TestCase(DayOfWeek.Sunday, "Sun")]
            public void WhenIsDefined_ThenReturnCorrectString(DayOfWeek dayOfWeek, string expected)
            {
                var result = dayOfWeek.ToStringShort();

                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenIsNotDefined_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => ((DayOfWeek)8).ToStringShort());
            }
        }
    }
}