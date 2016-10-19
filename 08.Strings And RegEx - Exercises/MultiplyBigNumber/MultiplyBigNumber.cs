using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondNum = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            if (firstNum == "0" || secondNum == 0 || firstNum == "")
            {
                Console.WriteLine(0);
                return;
            }

            int sum = 0;
            int numberInMind = 0;
            int remainder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = (int.Parse(firstNum[i].ToString()) * secondNum + numberInMind);
                numberInMind = sum / 10;
                remainder = sum % 10;
                result.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }
            }

            char[] resultToChar = result.ToString().ToCharArray();
            Console.WriteLine(string.Join("", resultToChar.Reverse()));
        }
    }
}