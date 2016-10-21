using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var averange = nums.Average();
            var greaterThanAverange = nums.Where(x => x > averange).ToArray();

            if (greaterThanAverange.Length == 0)
            {
                Console.WriteLine("No");
            }

            else
            {
                foreach (var num in greaterThanAverange.OrderByDescending(o => o).Take(5))
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}