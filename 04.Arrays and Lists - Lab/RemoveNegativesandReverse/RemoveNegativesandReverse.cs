using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesandReverse
{
    public class RemoveNegativesandReverse
    {
        public static void Main()
        {
            /*var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            foreach (var num in nums)
            {
                if (num>=0)
                {
                    list.Add(num);
                }
            }
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }*/

            //variant two
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}