using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int reverse = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                reverse = 0;
                while (nums[i] > 0)
                {
                    int rev = nums[i] % 10;
                    reverse = (reverse * 10) + rev;
                    nums[i] = nums[i] / 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}