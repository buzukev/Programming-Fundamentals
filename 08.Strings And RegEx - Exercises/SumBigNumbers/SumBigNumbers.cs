using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart(new char[] { '0' });
            string secondNum = Console.ReadLine().TrimStart(new char[] { '0' });

            StringBuilder Sum = new StringBuilder();

            int sum = 0;
            int numberInMind = 0;
            int remainder = 0;

            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = (int)(int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + numberInMind);
                numberInMind = (int)(sum / 10);
                remainder = (int)(sum % 10);
                Sum.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    Sum.Append(numberInMind);
                }
            }

            char[] resultToChar = Sum.ToString().ToCharArray();
            Array.Reverse(resultToChar);
            Console.WriteLine(new string(resultToChar));
        }
    }
}