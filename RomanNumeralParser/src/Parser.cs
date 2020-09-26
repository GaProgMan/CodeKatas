using System;
using System.Collections.Generic;
using System.Linq;

namespace src
{
    public class Parser : IDisposable
    {
        public enum Numeral
        {
            Default = 0, // can't parse this numeral (sentinel value)
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
        public int Parse(string input)
        {
            input.MustBeRomanNumeral();
            var listOfValues = new List<int>();
            // Old code, don't use
//            // input = "MCMLXXXVI
//            // input.ToCharArray() means
//            //    M, C, M, L, X, X, X, V, I
//            // listOfValues now reads
//            //    1000 100 1000 50 10 10 10 5 1
//            foreach (var ch in input.ToCharArray())
//            {
//                switch (ch)
//                {
//                    case 'I':
//                        listOfValues.Add(1);
//                        break;
//                    case 'V':
//                        listOfValues.Add(5);
//                        break;
//                    case 'X':
//                        listOfValues.Add(10);
//                        break;
//                    case 'L':
//                        listOfValues.Add(50);
//                        break;
//                    case 'C':
//                        listOfValues.Add(100);
//                        break;
//                    case 'D':
//                        listOfValues.Add(500);
//                        break;
//                    case 'M':
//                        listOfValues.Add(1000);
//                        break;
//                }
//            }
            // need to read the current character, then read the next one. If the next one is the next value up
            // then we need to subtract the current characters value from the next one and move opn to the one
            // after that
            // i.e input = XLV
            //    read X
            //    read L
            //    subtract X from L
            //    store 40 (L - X)
            //    read V
            //    store 5

            // MCMLXXXVI length = 9
            
            // input = "I"
            // input.length = 1
            // input[index] = I
            // input[index + 1 = ???
            for (var index = 0; index < input.Length; index++)
            {
                // get character at position index
                var current = input[index];     // L
                
                var currentAsEnum = (Numeral)Enum.Parse(typeof(Numeral), current.ToString(), true);
                var nextAsEnum = Numeral.Default;
                
                // index = 0
                // index + 1 = 1
                // input.length = 1
                // is index + 1 (which is 1) less than input.length (which is 1)? NO
                if (index + 1 < input.Length)
                {
                    var next = input[index + 1];    // X
                    nextAsEnum = (Numeral)Enum.Parse(typeof(Numeral), next.ToString(), true);
                }
                
                // do some maths
                if (nextAsEnum > currentAsEnum)
                {
                    listOfValues.Add(nextAsEnum - currentAsEnum);
                    index++;
                }
                else
                {
                    listOfValues.Add((int)currentAsEnum);
                }
            }

            // listOfValues:
            //    1000
            //    900
            //    50
            //    10
            //    10
            //    10
            //    6
            return listOfValues.Sum();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    }
}