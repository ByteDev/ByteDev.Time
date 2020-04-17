using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateRangeTests
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void WhenStartIsAfterEnd_ThenThrowExceptions()
            {
                var start = DateTime.Now;
                var end = start.AddDays(-1);

                Assert.Throws<ArgumentException>(() => new DateRange(start, end));
            }

            [Test]
            public void WhenStartEqualEnd_ThenSetProperties()
            {
                var start = DateTime.Now;
                var end = start;

                var sut = new DateRange(start, end);

                Assert.That(sut.Start, Is.EqualTo(new DateTime(start.Year, start.Month, start.Day)));
                Assert.That(sut.End, Is.EqualTo(new DateTime(end.Year, end.Month, end.Day)));
            }

            [Test]
            public void WhenStartIsBeforeEnd_ThenSetProperties()
            {
                var start = DateTime.Now;
                var end = start.AddDays(1);

                var sut = new DateRange(start, end);

                Assert.That(sut.Start, Is.EqualTo(new DateTime(start.Year, start.Month, start.Day)));
                Assert.That(sut.End, Is.EqualTo(new DateTime(end.Year, end.Month, end.Day)));
            }
        }

        [TestFixture]
        public class IsInRange
        {
            private DateRange _sut;

            [SetUp]
            public void SetUp()
            {
                var start = new DateTime(2020, 1, 10);
                var end = new DateTime(2020, 1, 12);

                _sut = new DateRange(start, end);
            }

            [Test]
            public void WhenDateIsBeforeStart_ThenReturnFalse()
            {
                var result = _sut.IsInRange(_sut.Start.AddDays(-1));

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateTimeIsAfterEnd_ThenReturnFalse()
            {
                var result = _sut.IsInRange(_sut.End.AddDays(1));

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateTimeIsEqualStart_ThenReturnTrue()
            {
                var result = _sut.IsInRange(_sut.Start);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenDateTimeIsEqualEnd_ThenReturnTrue()
            {
                var result = _sut.IsInRange(_sut.End);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenDateTimeIsBetweenStartAndEnd_ThenReturnTrue()
            {
                var result = _sut.IsInRange(_sut.Start.AddDays(1));

                Assert.That(result, Is.True);
            }



            [Test]
            public void WhenDateRangeIsBeforeStart_ThenReturnFalse()
            {
                var range = new DateRange(_sut.Start.AddDays(-1), _sut.End);

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateRangeIsAfterEnd_ThenReturnFalse()
            {
                var range = new DateRange(_sut.Start, _sut.End.AddDays(1));

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateRangeIsEqualStartAndEnd_ThenReturnTrue()
            {
                var range = new DateRange(_sut.Start, _sut.End);

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.True);
            }
            
            [Test]
            public void WhenDateRangeIsBetweenStartAndEnd_ThenReturnTrue()
            {
                var range = new DateRange(_sut.Start.AddDays(1), _sut.End.AddDays(-1));

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.True);
            }
        }
    }
}