using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse);
            var sort = nums.OrderByDescending(x => x);
            var result = sort.Take(3);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}