using System;

namespace src
{
    public class FizzBuzz
    {
        public string Evaluate(int number)
        {
            var fizz = number % 3 == 0;
            var buzz = number % 5 == 0;

            if (fizz && buzz)
            {
                return "FizzBuzz";
            }

            if (fizz)
            {
                return "Fizz";
            }

            if (buzz)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
