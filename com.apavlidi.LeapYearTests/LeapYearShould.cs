using com.apavlidi.LeapYear;
using NUnit.Framework;

namespace LeapYearTests
{
    public class LeapYearShould
    {
        [Test]
        public void be_a_leap_year_if_divisible_by_4()
        {
            Assert.That(IsLeapYear(2000), Is.EqualTo(true));
        }

        [Test]
        public void not_a_be_a_leap_year_if_not_divisible_by_4()
        {
            Assert.That(IsLeapYear(2017), Is.EqualTo(false));
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_4_but_not_by_100()
        {
            Assert.That(IsLeapYear(2008), Is.EqualTo(true));
        }

        [Test]
        public void not_be_a_leap_year_if_divisible_by_100_but_not_by_400()
        {
            Assert.That(IsLeapYear(1700), Is.EqualTo(false));
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_400()
        {
            Assert.That(IsLeapYear(2000), Is.EqualTo(true));
        }

        private static bool IsLeapYear(int year)
        {
            return new LeapYear(year).isLeapYear();
        }
    }
}