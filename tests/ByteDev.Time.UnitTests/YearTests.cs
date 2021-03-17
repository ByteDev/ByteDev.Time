using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class YearTests
    {
        [TestFixture]
        public class IsLeap : YearTests
        {
            [TestCase(2028)]
            [TestCase(2024)]
            [TestCase(2020)]
            public void WhenYearIsLeap_ThenReturnTrue(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.IsLeap, Is.True);
            }

            [TestCase(2027)]
            [TestCase(2023)]
            [TestCase(2019)]
            public void WhenYearIsNotLeap_ThenReturnFalse(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.IsLeap, Is.False);
            }

            [TestCase(0)]
            [TestCase(-1)]
            [TestCase(10000)]
            public void WhenYearOutOfRange_ThenReturnFalse(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.IsLeap, Is.False);
            }
        }

        [TestFixture]
        public class Decade : YearTests
        {
            [TestCase(-1000)]
            [TestCase(-100)]
            [TestCase(-9)]
            [TestCase(-1)]
            [TestCase(0)]
            [TestCase(9)]
            [TestCase(100)]
            [TestCase(1000)]
            public void WhenYearHasNoDecade_ThenReturnZero(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.Decade, Is.EqualTo(0));
            }

            [TestCase(-1020)]
            [TestCase(-120)]
            [TestCase(20)]
            [TestCase(120)]
            [TestCase(1020)]
            public void WhenYearHasDecade_ThenReturnDecade(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.Decade, Is.EqualTo(20));
            }
        }

        [TestFixture]
        public class Century : YearTests
        {
            [TestCase(-99)]
            [TestCase(-1)]
            [TestCase(0)]
            [TestCase(99)]
            public void WhenYearHasNoCentury_ThenReturnZero(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.Century, Is.EqualTo(0));
            }

            [TestCase(-1099, -10)]
            [TestCase(-1000, -10)]
            [TestCase(-120, -1)]
            [TestCase(120, 1)]
            [TestCase(1020, 10)]
            [TestCase(2100, 21)]
            [TestCase(2199, 21)]
            public void WhenYearHasCentury_ThenReturnCentury(int year, int expected)
            {
                var sut = new Year(year);

                Assert.That(sut.Century, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class Millennium : YearTests
        {
            [TestCase(-999)]
            [TestCase(-1)]
            [TestCase(0)]
            [TestCase(999)]
            public void WhenYearHasNoMillennium_ThenReturnZero(int year)
            {
                var sut = new Year(year);

                Assert.That(sut.Millennium, Is.EqualTo(0));
            }

            [TestCase(-2000, -2)]
            [TestCase(-1999, -1)]
            [TestCase(-1000, -1)]
            [TestCase(1099, 1)]
            [TestCase(2000, 2)]
            [TestCase(2999, 2)]
            public void WhenYearHasMillennium_ThenReturnCentury(int year, int expected)
            {
                var sut = new Year(year);

                Assert.That(sut.Millennium, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class ToStringOverride : YearTests
        {
            [Test]
            public void WhenCalled_ThenReturnsYear()
            {
                var sut = new Year(2021);

                var result = sut.ToString();

                Assert.That(result, Is.EqualTo("2021"));
            }
        }
    }
}