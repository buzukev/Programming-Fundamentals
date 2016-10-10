using System;
using System.Linq;

namespace CondenseArraytoNumber
{
    public class CondenseArraytoNumber
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (nums.Length >= 2)
            {
                var result = new int[nums.Length - 1];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
            }
            Console.WriteLine(nums[0]);

            //variant two
            /*var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j] + nums[j + 1];
                }
            }
            Console.WriteLine(nums[0]);*/
        }
    }
}