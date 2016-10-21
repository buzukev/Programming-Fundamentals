using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = @"(\D+)(\d+)";

            Regex regex = new Regex(pattern);

            int count = 0;

            StringBuilder sb = new StringBuilder();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    sb.Append(match.Groups[1]);
                }
            }

            count = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine($"{sb}");
        }
    }
}