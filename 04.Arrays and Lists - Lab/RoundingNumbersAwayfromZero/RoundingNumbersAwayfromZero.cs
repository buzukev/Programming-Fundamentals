using System;
using System.Linq;

namespace RoundingNumbersAwayfromZero
{
    public class RoundingNumbersAwayfromZero
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            foreach (var num in nums)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {rounded}");
            }
        }
    }
}