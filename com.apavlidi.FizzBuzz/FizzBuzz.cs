namespace com.apavlidi
{
    public class FizzBuzz
    {
        private const string BUZZ = "BUZZ";
        private const string FIZZ = "FIZZ";
        private const string FIZZ_BUZZ = "FIZZ_BUZZ";

        public static string Convert(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
                return FIZZ_BUZZ;
            if (number % 5 == 0)
                return BUZZ;
            if (number % 3 == 0)
                return FIZZ;

            return number.ToString();
        }
    }
}