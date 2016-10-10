using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] bombInfo = Console.ReadLine().Split(' ');
            int target = int.Parse(bombInfo[0]);
            int radius = int.Parse(bombInfo[1]);

            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }

            while (numbers.Contains(target))
            {
                int index = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (target == numbers[i])
                    {
                        index = i;
                        break;
                    }
                }
                int bombLen = 2 * radius + 1;
                int start = Math.Max(0, index - radius);
                int finish = Math.Min(bombLen, numbers.Count - start);
                numbers.RemoveRange(start, finish);
            }
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}