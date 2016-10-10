using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            /*string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int counterLeftToRight = 0;
            int counterRightToLeft = 0;
            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterLeftToRight++;
                    continue;
                }
                break;
            }
            for (int j = 0; j < arr1.Length && j < arr2.Length; j++)
            {
                if (arr1[arr1.Length - 1 - j] == arr2[arr2.Length - 1 - j])
                {
                    counterRightToLeft++;
                }
            }
            if (counterRightToLeft > counterLeftToRight)
            {
                Console.WriteLine(counterRightToLeft);
            }
            else
            {
                Console.WriteLine(counterLeftToRight);
            }*/

            //variant two
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int counterLeftToRight = 0;
            int counterRightToLeft = 0;
            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterLeftToRight++;
                    continue;
                }
                break;
            }
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterRightToLeft++;
                    continue;
                }
                break;
            }
            Console.WriteLine(Math.Max(counterRightToLeft, counterLeftToRight));
        }
    }
}