using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "MMCCXXXVI";
            var output = input.ParseRomanNumeral();

            Console.WriteLine($"{input} is {output}");
            if (output == 2236)
            {
                Console.WriteLine("PASS!");
            }
            
            // MMCCXXXVI is 2236
        }
    }
}
