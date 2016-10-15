using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;

namespace EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            string[] nums = File.ReadAllText("input.txt").Split(' ').ToArray();

            bool isTrue = false;

            for (int currentPosition = 0; currentPosition < nums.Length; currentPosition++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int i = currentPosition + 1; i < nums.Length; i++)
                {
                    rightSum += int.Parse(nums[i]);
                }

                for (int i = 0; i < currentPosition; i++)
                {
                    leftSum += int.Parse(nums[i]);
                }

                if (leftSum == rightSum)
                {
                    File.AppendAllText("output.txt", string.Join("", currentPosition));
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                File.AppendAllText("output.txt", $"no");
            }
        }
    }
}