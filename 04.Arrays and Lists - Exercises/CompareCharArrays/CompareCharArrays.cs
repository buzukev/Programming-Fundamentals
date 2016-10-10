using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            List<char> charsArr1 = new List<char>();
            List<char> charsArr2 = new List<char>();

            for (int i = 0; i < arr1.Length; i++)
            {
                charsArr1.Add(char.Parse(arr1[i]));
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                charsArr2.Add(char.Parse(arr2[i]));
            }
            int len = Math.Min(charsArr1.Count, charsArr2.Count);
            bool isDifferent = false;

            for (int i = 0; i < len; i++)
            {
                if (charsArr1[i] > charsArr2[i])
                {
                    Console.WriteLine(string.Join("", charsArr2));
                    Console.WriteLine(string.Join("", charsArr1));
                    isDifferent = true;
                    break;
                }
                if (charsArr1[i] < charsArr2[i])
                {
                    Console.WriteLine(string.Join("", charsArr1));
                    Console.WriteLine(string.Join("", charsArr2));
                    isDifferent = true;
                    break;
                }
            }
            if (!isDifferent)
            {
                if (charsArr1.Count <= charsArr2.Count)
                {
                    Console.WriteLine(string.Join("", charsArr1));
                    Console.WriteLine(string.Join("", charsArr2));
                }
                else
                {
                    Console.WriteLine(string.Join("", charsArr2));
                    Console.WriteLine(string.Join("", charsArr1));
                }
            }
        }
    }
}