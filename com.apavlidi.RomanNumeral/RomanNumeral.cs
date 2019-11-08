using System.Collections.Generic;

namespace com.apavlidi.RomanNumeral
{
    public class RomanNumeral
    {
        public static string convert(int dec)
        {
            var result = "";
            var romanNumerals = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

            foreach (var keyValuePair in romanNumerals)
            {
                while (dec >= keyValuePair.Key)
                {
                    result += keyValuePair.Value;
                    dec -= keyValuePair.Key;
                }
            }

            return result;
        }
    }
}