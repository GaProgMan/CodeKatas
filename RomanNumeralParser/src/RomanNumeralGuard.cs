using System;
using System.Collections.Generic;
using System.Linq;

namespace src
{
    public static class RomanNumeralGuard
    {
        private static readonly List<string> _numerals = new List<string> {"I", "V", "X", "L", "C", "D", "M"};
        public static void MustBeRomanNumeral(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"{nameof(input)} is null or empty");
            }
            
            // input = "iVXJEFF"
            // input.All(ch => = "i", "V", "X", "J", "E", "F", "F"
            // _numerals.Contains(ch) == take ch and compare it to all of the characters in the list
            // all of these have to pass (return true) for the string to be valid
            
            // JEFF
            // J E F F
            // does J exist in _numerals? No
            // does E exist in _numerals? No
            // does E exist in _numerals? No
            // does F exist in _numerals? No
            // No & No & No & No == No
            // ! turns Yes into No, also No into Yes
            
            if (!input.All(ch => _numerals.Contains(ch.ToString(), StringComparer.CurrentCultureIgnoreCase)))
            {
                throw new ArgumentException($"{nameof(input)} is not a Roman Numeral");
            }
        }
    }
}