using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class MonthExtensionsTests
    {
        [TestFixture]
        public class ToStringShort
        {
            [TestCase(Month.January, "Jan")]
            [TestCase(Month.February, "Feb")]
            [TestCase(Month.March, "Mar")]
            [TestCase(Month.April, "Apr")]
            [TestCase(Month.May, "May")]
            [TestCase(Month.June, "Jun")]
            [TestCase(Month.July, "Jul")]
            [TestCase(Month.August, "Aug")]
            [TestCase(Month.September, "Sep")]
            [TestCase(Month.October, "Oct")]
            [TestCase(Month.November, "Nov")]
            [TestCase(Month.December, "Dec")]
            public void WhenIsDefined_ThenReturnCorrectString(Month month, string expected)
            {
                var result = month.ToStringShort();

                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenIsNotDefined_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => ((Month)13).ToStringShort());
            }
        }
    }
}