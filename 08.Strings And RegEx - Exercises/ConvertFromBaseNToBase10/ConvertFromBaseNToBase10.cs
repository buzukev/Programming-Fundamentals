using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertFromBaseNToBase10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            /*string[] input = Console.ReadLine().Trim().Split();

            int baseN = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();
            BigInteger result = new BigInteger();

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[j]));
                BigInteger sum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += sum;
            }
            Console.WriteLine(result.ToString());*/

            // variant two:

            string[] intput = Console.ReadLine().Split();
            int baseToConvert = int.Parse(intput[0]);
            string numberToConvert = intput[1];

            BigInteger result = 0;

            for (int i = 0; i < numberToConvert.Length; i++)
            {
                result += (BigInteger)(int.Parse(numberToConvert[i].ToString()) * Math.Pow(baseToConvert, (double)numberToConvert.Length - i - 1));
            }
            Console.WriteLine(result);
        }
    }
}

