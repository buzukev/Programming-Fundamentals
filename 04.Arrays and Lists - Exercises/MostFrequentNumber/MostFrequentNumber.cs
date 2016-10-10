using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int frequentNum = 0;
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            frequentNum = nums[i];
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine(frequentNum);
        }
    }
}