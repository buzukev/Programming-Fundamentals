using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldandSum
{
    public class FoldandSum
    {
        public static void Main()
        {
            /*string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            int k = input.Length / 4;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            int[] firstRow = new int[2 * k];
            int[] secondRow = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = numbers[k-i-1];
            }

            for (int i = 0; i < k; i++)
            {
                firstRow[k + i] = numbers[4 * k - i - 1];
            }

            for (int i = 0; i < 2*k; i++)
            {
                secondRow[i] = numbers[k + i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }*/

            //variant two

            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];

            int k = input.Length / 4;
            int[] firstElements = new int[k];
            int[] lastElements = new int[k];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            for (int i = 0; i < k; i++)
            {
                firstElements[i] = numbers[i];
                lastElements[i] = numbers[3 * k + i];
            }
            Array.Reverse(firstElements);
            Array.Reverse(lastElements);

            int[] result = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                result[i] = firstElements[i] + numbers[k + i];
                result[k + i] = lastElements[i] + numbers[2 * k + i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
