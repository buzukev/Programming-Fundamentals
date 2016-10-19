using System;
using System.Collections.Generic;
using System.Linq;

namespace UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string charToUnicode = "0000".Substring(0, 4 - ((int)(input[i])).ToString("x").Length) + ((int)(input[i])).ToString("x");
                Console.Write("\\u{0}", charToUnicode);
            }
            Console.WriteLine();
        }
    }
}