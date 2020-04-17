using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeRangeTests
    {
        [TestFixture]
        public class Constructor
        {
            [Test]
            public void WhenStartIsAfterEnd_ThenThrowExceptions()
            {
                var start = DateTime.Now;
                var end = start.AddMilliseconds(-1);

                Assert.Throws<ArgumentException>(() => new DateTimeRange(start, end));
            }

            [Test]
            public void WhenStartEqualEnd_ThenSetProperties()
            {
                var start = DateTime.Now;
                var end = start;

                var sut = new DateTimeRange(start, end);

                Assert.That(sut.Start, Is.EqualTo(start));
                Assert.That(sut.End, Is.EqualTo(end));
            }

            [Test]
            public void WhenStartIsBeforeEnd_ThenSetProperties()
            {
                var start = DateTime.Now;
                var end = start.AddMilliseconds(1);

                var sut = new DateTimeRange(start, end);

                Assert.That(sut.Start, Is.EqualTo(start));
                Assert.That(sut.End, Is.EqualTo(end));
            }
        }

        [TestFixture]
        public class IsInRange
        {
            private DateTimeRange _sut;

            [SetUp]
            public void SetUp()
            {
                var start = new DateTime(2020, 1, 10);
                var end = new DateTime(2020, 1, 11);

                _sut = new DateTimeRange(start, end);
            }

            [Test]
            public void WhenDateTimeIsBeforeStart_ThenReturnFalse()
            {
                var result = _sut.IsInRange(_sut.Start.AddMilliseconds(-1));

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateTimeIsAfterEnd_ThenReturnFalse()
            {
                var result = _sut.IsInRange(_sut.End.AddMilliseconds(1));

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
                var result = _sut.IsInRange(_sut.Start.AddMilliseconds(1));

                Assert.That(result, Is.True);
            }



            [Test]
            public void WhenDateTimeRangeIsBeforeStart_ThenReturnFalse()
            {
                var range = new DateTimeRange(_sut.Start.AddMilliseconds(-1), _sut.End);

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateTimeRangeIsAfterEnd_ThenReturnFalse()
            {
                var range = new DateTimeRange(_sut.Start, _sut.End.AddMilliseconds(1));

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenDateTimeRangeIsEqualStartAndEnd_ThenReturnTrue()
            {
                var range = new DateTimeRange(_sut.Start, _sut.End);

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.True);
            }
            
            [Test]
            public void WhenDateTimeRangeIsBetweenStartAndEnd_ThenReturnTrue()
            {
                var range = new DateTimeRange(_sut.Start.AddMilliseconds(1), _sut.End.AddMilliseconds(-1));

                var result = _sut.IsInRange(range);

                Assert.That(result, Is.True);
            }
        }
    }
}