namespace com.apavlidi.LeapYear
{
    public class LeapYear
    {
        private readonly int _year;

        public LeapYear(int year)
        {
            _year = year;
        }


        public bool isLeapYear()
        {
            return (isDivisibleBy(4) && !(isDivisibleBy(100) && isNotDivisibleBy(400)));
        }

        private bool isNotDivisibleBy(int number)
        {
            return _year % number != 0;
        }

        private bool isDivisibleBy(int number)
        {
            return _year % number == 0;
        }
    }
}