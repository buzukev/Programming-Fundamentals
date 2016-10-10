using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            /*var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i]>0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }*/

            //variant two
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            var start = 0;
            var counts = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1 || nums[i] != nums[i+1]) 
                {
                    Console.WriteLine($"{nums[start]} -> {counts}");
                    start = i + 1;
                    counts = 1;
                }
                else
                {
                    counts++;
                }
            }
        }
    }
}