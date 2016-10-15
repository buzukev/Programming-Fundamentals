using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MaxSequenceofEqualElements
{
    class MaxSequenceofEqualElements
    {
        static void Main()
        {
            string[] nums = File.ReadAllText("input.txt").Split(' ').ToArray();

            int position = 0;
            int counter = 0;
            int maxCounter = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        position = i - counter + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = position + 1; i <= position + maxCounter; i++)
            {
                File.AppendAllText("output.txt", nums[i] + " ");
            }
        }
    }
}