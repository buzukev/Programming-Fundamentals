using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterMultiplier
{
    public class CharacterMultiplier
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string str1 = input[0];
            string str2 = input[1];

            int sum = 0;
            string maxString = "";

            int maxLength = Math.Max(str1.Length, str2.Length);
            int minLength = Math.Min(str1.Length, str2.Length);

            if (str1.Length >= str2.Length)
            {
                maxString = str1;
            }
            else
            {
                maxString = str2;
            }
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    sum += str1[i] * str2[i];
                }
                else
                {
                    sum += maxString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}