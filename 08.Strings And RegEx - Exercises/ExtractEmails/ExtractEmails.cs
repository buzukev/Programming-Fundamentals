using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string emailRegex =
                @"\s([a-zA-Z\d][a-zA-Z\d\.\-_]*[a-zA-Z\d]@(?:[a-zA-Z][a-zA-Z\-]*[a-zA-Z]\.){1,}[a-zA-Z][a-zA-Z\-]*[a-zA-Z])";
            var matches = Regex.Matches(input, emailRegex);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}