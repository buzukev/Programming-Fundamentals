using System;
using System.Linq;

namespace ExtractMiddle1or2or3Elements
{
    public class ExtractMiddle1or2or3Elements
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = ExtractMiddleElements(nums);
            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        private static int[] ExtractMiddleElements(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            if (nums.Length % 2 == 0)
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
            }
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1]};
        }
    }
}