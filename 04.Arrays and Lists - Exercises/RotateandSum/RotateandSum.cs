using System;
using System.Collections.Generic;
using System.Linq;

namespace RotateandSum
{
    public class RotateandSum
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] numbers = ParseNumbers(arr);
            long[] sum = new long[arr.Length];
            Rotations(numbers, sum, rotations);
            Console.WriteLine(string.Join(" ", sum));
        }

        private static void Rotations(int[] numbers, long[] sum, int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int lastElement = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastElement;
                for (int k = 0; k < numbers.Length; k++)
                {
                    sum[k] += numbers[k];
                }
            }
        }
        public static int[] ParseNumbers(string[] arr)
        {
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            return numbers;
        }
    }
}
