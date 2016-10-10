using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isTrue = false;
            for (int currentPos = 0; currentPos < nums.Length; currentPos++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int i = currentPos+1; i < nums.Length; i++)
                {
                    rightSum += nums[i];
                }
                for (int i = 0; i < currentPos; i++)
                {
                    leftSum += nums[i];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(currentPos);
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}