using NUnit.Framework;
using static com.apavlidi.RomanNumeral.RomanNumeral;

namespace com.apavlidi.RomanNumeralTests
{
    public class RomanNumeralShould
    {
        [Test]
        public void convert_decimal_to_roman_numeral()
        {
            Assert.That(convert(1), Is.EqualTo("I"));
            Assert.That(convert(2), Is.EqualTo("II"));
            Assert.That(convert(3), Is.EqualTo("III"));
            Assert.That(convert(4), Is.EqualTo("IV"));
            Assert.That(convert(5), Is.EqualTo("V"));
            Assert.That(convert(6), Is.EqualTo("VI"));
            Assert.That(convert(8), Is.EqualTo("VIII"));
            Assert.That(convert(10), Is.EqualTo("X"));
            Assert.That(convert(11), Is.EqualTo("XI"));
            Assert.That(convert(11), Is.EqualTo("XI"));
            Assert.That(convert(19), Is.EqualTo("XIX"));
            Assert.That(convert(999), Is.EqualTo("CMXCIX"));
            Assert.That(convert(2017), Is.EqualTo("MMXVII"));
        }
    }
}