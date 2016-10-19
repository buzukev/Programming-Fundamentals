using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string split = @"\W+";
            string[] userNames = Regex.Replace(input, split, " ").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";

            Regex regex = new Regex(pattern);
            List<string> list = new List<string>();

            foreach (var user in userNames)
            {
                if (regex.IsMatch(user))
                {
                    list.Add(user);
                }
            }

            int currentSum = 0;
            int sum = 0;
            string str1 = string.Empty;
            string str2 = "";

            for (int i = 1; i < list.Count; i++)
            {
                currentSum = list[i - 1].Length + list[i].Length;

                if (currentSum > sum)
                {
                    sum = currentSum;
                    str1 = list[i-1];
                    str2 = list[i];
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}