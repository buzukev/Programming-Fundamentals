using System;
using System.Linq;
using System.Collections.Generic;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}