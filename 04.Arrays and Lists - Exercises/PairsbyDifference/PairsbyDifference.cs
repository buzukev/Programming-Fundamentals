using System;
using System.Collections.Generic;
using System.Linq;

namespace PairsbyDifference
{
    public class PairsbyDifference
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[j] - nums[i]) == difference && i < j)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

            //variant two

            /*int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length-1; j > i; j--)
                {
                    if (Math.Abs(nums[j] - nums[i]) == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);*/
        }
    }
}