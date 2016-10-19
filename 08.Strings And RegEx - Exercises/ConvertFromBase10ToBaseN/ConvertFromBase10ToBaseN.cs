using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int baseToConvert = int.Parse(input[0]);
            BigInteger numberToConvert = BigInteger.Parse(input[1]);

            string result = "";

            while (numberToConvert > 0)
            {
                result += numberToConvert % baseToConvert;
                numberToConvert /= baseToConvert;
            }

            char[] resultToChar = result.ToCharArray();
            Console.WriteLine(string.Join("", resultToChar.Reverse()));
        }
    }
}