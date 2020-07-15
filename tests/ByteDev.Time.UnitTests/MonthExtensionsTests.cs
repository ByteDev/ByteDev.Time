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
            public void WhenIsDefined_ThenReturnCorrectString(Month sut, string expected)
            {
                var result = sut.ToStringShort();

                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenIsNotDefined_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => ((Month)13).ToStringShort());
            }
        }

        [TestFixture]
        public class Length
        {
            [TestCase(Month.January, 2020, 31)]
            [TestCase(Month.February, 2020, 29)]
            [TestCase(Month.February, 2021, 28)]
            [TestCase(Month.March, 2020, 31)]
            [TestCase(Month.April, 2020, 30)]
            [TestCase(Month.May, 2020, 31)]
            [TestCase(Month.June, 2020, 30)]
            [TestCase(Month.July, 2020, 31)]
            [TestCase(Month.August, 2020, 31)]
            [TestCase(Month.September, 2020, 30)]
            [TestCase(Month.October, 2020, 31)]
            [TestCase(Month.October, 2020, 31)]
            [TestCase(Month.November, 2020, 30)]
            [TestCase(Month.December, 2020, 31)]
            public void WhenIsLeapYear_Then(Month sut, int year, int expected)
            {
                var result = sut.Length(year);

                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}