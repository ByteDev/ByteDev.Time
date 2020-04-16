﻿using System;
using NUnit.Framework;

namespace ByteDev.Time.UnitTests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [TestFixture]
        public class GetDayAsOrdinal
        {
            [Test]
            [TestCase(1, "st")]
            [TestCase(2, "nd")]
            [TestCase(3, "rd")]
            [TestCase(4, "th")]
            [TestCase(5, "th")]
            [TestCase(6, "th")]
            [TestCase(7, "th")]
            [TestCase(8, "th")]
            [TestCase(9, "th")]
            [TestCase(10, "th")]
            [TestCase(11, "th")]
            [TestCase(12, "th")]
            [TestCase(13, "th")]
            [TestCase(14, "th")]
            [TestCase(15, "th")]
            [TestCase(16, "th")]
            [TestCase(17, "th")]
            [TestCase(18, "th")]
            [TestCase(19, "th")]
            [TestCase(20, "th")]
            [TestCase(21, "st")]
            [TestCase(22, "nd")]
            [TestCase(23, "rd")]
            [TestCase(24, "th")]
            [TestCase(25, "th")]
            [TestCase(26, "th")]
            [TestCase(27, "th")]
            [TestCase(28, "th")]
            [TestCase(29, "th")]
            [TestCase(30, "th")]
            [TestCase(31, "st")]
            public void WhenDayProvided_ThenReturnCorrectSuffix(int day, string expectedSuffix)
            {
                var sut = new DateTime(2000, 1, day);

                var result = sut.GetDayAsOrdinal();

                Assert.That(result, Is.EqualTo($"{day}{expectedSuffix}"));
            }
        }

        [TestFixture]
        public class SubtractWeeks
        {
            [Test]
            public void WhenWeeksIsOne_ThenSubtractOneWeekFromDate()
            {
                var expected = new DateTime(2000, 1, 10);
                var sut = new DateTime(2000, 1, 17);

                var result = sut.SubtractWeeks(1);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class AddWeeks
        {
            [Test]
            public void WhenWeeksIsOne_ThenAddOneWeekFromDate()
            {
                var expected = new DateTime(2000, 1, 24);
                var sut = new DateTime(2000, 1, 17);

                var result = sut.AddWeeks(1);

                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}
