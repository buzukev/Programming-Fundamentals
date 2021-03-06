﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}