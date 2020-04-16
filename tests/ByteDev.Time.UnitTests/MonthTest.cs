using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class MonthTest
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void WhenMonthNumberIsZero_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Month(0));
            }

            [Test]
            public void WhenMonthNumberIsThirteen_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Month(13));
            }

            [Test]
            public void WhenMonthNumberIsBetweenOneAndTwelve_ThenSetMonthNumber()
            {
                const int monthNumber = 1;
                var sut = new Month(monthNumber);

                var result = sut.Number;

                Assert.That(result, Is.EqualTo(monthNumber));
            }
        }

        [TestFixture]
        public class Name
        {
            [TestCase(1, ExpectedResult = "January")]
            [TestCase(2, ExpectedResult = "February")]
            [TestCase(3, ExpectedResult = "March")]
            [TestCase(4, ExpectedResult = "April")]
            [TestCase(5, ExpectedResult = "May")]
            [TestCase(6, ExpectedResult = "June")]
            [TestCase(7, ExpectedResult = "July")]
            [TestCase(8, ExpectedResult = "August")]
            [TestCase(9, ExpectedResult = "September")]
            [TestCase(10, ExpectedResult = "October")]
            [TestCase(11, ExpectedResult = "November")]
            [TestCase(12, ExpectedResult = "December")]
            public string WhenMonthNumberValid_ThenReturnCorrectName(int monthNumber)
            {
                var sut = new Month(monthNumber);

                return sut.Name;
            } 
        }

        [TestFixture]
        public class ShortName
        {
            [TestCase(1, ExpectedResult = "Jan")]
            [TestCase(2, ExpectedResult = "Feb")]
            [TestCase(3, ExpectedResult = "Mar")]
            [TestCase(4, ExpectedResult = "Apr")]
            [TestCase(5, ExpectedResult = "May")]
            [TestCase(6, ExpectedResult = "Jun")]
            [TestCase(7, ExpectedResult = "Jul")]
            [TestCase(8, ExpectedResult = "Aug")]
            [TestCase(9, ExpectedResult = "Sep")]
            [TestCase(10, ExpectedResult = "Oct")]
            [TestCase(11, ExpectedResult = "Nov")]
            [TestCase(12, ExpectedResult = "Dec")]
            public string WhenMonthNumberValid_ThenReturnCorrectName(int monthNumber)
            {
                var sut = new Month(monthNumber);

                return sut.ShortName;
            } 
        }
    }
}