using System;
using src;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new src.FizzBuzz();
            for(var i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i} => FizzBuzz => {fizzBuzz.Evaluate(i)}");
            }
        }
    }
}
