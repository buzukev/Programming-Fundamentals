using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var counts = new SortedDictionary<decimal, int>();
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var i in counts.Keys)
            {
                Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}