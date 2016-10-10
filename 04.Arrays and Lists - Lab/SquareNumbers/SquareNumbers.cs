using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var square = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    square.Add(num);
                }
            }
            square.Sort(((a, b) => b.CompareTo(a)));
            Console.WriteLine(string.Join(" ", square));
        }
    }
}