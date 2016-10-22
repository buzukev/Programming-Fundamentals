using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];
            int[] previous = new int[nums.Length];
            int maxLen = 0;
            int maxIndex = -1;

            for (int current = 0; current < nums.Length; current++)
            {
                len[current] = 1;
                previous[current] = -1;

                for (int prev = 0; prev <= current; prev++)
                {
                    if (nums[current] > nums[prev] && len[prev] + 1 > len[current])
                    {
                        len[current] = len[prev] + 1;
                        previous[current] = prev;
                    }
                    if (len[current] > maxLen)
                    {
                        maxLen = len[current];
                        maxIndex = current;
                    }
                }
            }
            var list = new List<int>();

            while (maxIndex != -1)
            {
                list.Add(nums[maxIndex]);
                maxIndex = previous[maxIndex];
            }
            list.Reverse();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}