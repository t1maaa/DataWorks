using System;
using System.Collections.Generic;

namespace DataWorks.Tests
{
    public static class DataWorks
    {
        #region RomanToInt

        public static int RomanToInt(string romanNumber)
        {
            if (string.IsNullOrWhiteSpace(romanNumber) || int.TryParse(romanNumber, out _)) return 0;
            var romanValues = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int number = 0;
            
            for (var i = 0; i < romanNumber.Length; i++)
            {
                if (romanValues.TryGetValue(romanNumber[i], out var curVal))
                {
                    if ( (i + 1 <= romanNumber.Length - 1) && romanValues.TryGetValue(romanNumber[i + 1], out var nextVal))
                    {
                        if (curVal >= nextVal)
                            number += curVal;
                        else
                            number -= curVal;
                    }
                    else
                        number += curVal;
                }
            }
            return number;
        }

        #endregion

        #region IsBracketsBalanced

        public static bool IsBracketsBalanced(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentException("Empty string");

            var leftBracket = 0;
            var rightBracket = 0;
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        leftBracket++;
                        break;
                    case ')':
                        rightBracket++;
                        break;
                }

                if (rightBracket > leftBracket) return false;
            }
            return rightBracket == leftBracket;
        }

        #endregion
    }
}