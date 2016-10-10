using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' };
            string[] words = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Where(x => x != "" && x.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(String.Join(", ", result));
        }
    }
}