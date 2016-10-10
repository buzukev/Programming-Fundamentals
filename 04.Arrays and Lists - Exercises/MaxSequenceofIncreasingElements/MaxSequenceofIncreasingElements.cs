using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceofIncreasingElements
{
    public class MaxSequenceofIncreasingElements
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int pos = 0;
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int firstNum = nums[i];
                int secondNum = nums[i + 1];
                if (secondNum >= firstNum + 1)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        pos = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = pos + 1; i <= pos + maxCount; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}