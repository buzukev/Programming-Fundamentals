using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            /*List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            var result = new List<string>();
            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));*/

            //variant two
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            var result = new List<string>();
            foreach (var item in items)
            {
                List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}