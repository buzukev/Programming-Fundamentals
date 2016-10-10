using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    public class MaxSequenceofEqualElements
    {
        public static void Main()
        {
            /*int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int pos = 0;
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        pos = i - count+1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = pos+1; i <= pos + maxCount; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();*/

            //variatn two with list

            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double count = 1;
            double maxCount = 1;
            double num = nums[0];

            for (int pos = 0; pos < nums.Count; pos++)
            {
                if (pos + 1 >= nums.Count)
                {
                    break;
                }

                if (nums[pos] == nums[pos + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = nums[pos];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}