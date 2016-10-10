using System;
using System.Linq;
using System.Collections.Generic;

namespace SplitbyWordCasing
{
    public class SplitbyWordCasing
    {
        public static void Main()
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type == WordType.LowerCase)
                {
                    lowerCaseList.Add(w);
                }
                else if (type == WordType.UpperCase)
                {
                    upperCaseList.Add(w);
                }
                else
                {
                    mixedCaseList.Add(w);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseList)}\r\nMixed-case: {string.Join(", ", mixedCaseList)}\r\nUpper-case: {string.Join(", ", upperCaseList)}");
        }
        enum WordType { UpperCase, MixedCase, LowerCase }
        static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var len in word)
            {
                if (char.IsLower(len))
                {
                    lowerLetters++;
                }
                else if (char.IsUpper(len))
                {
                    upperLetters++;
                }
            }
            if (lowerLetters == word.Length)
            {
                return WordType.LowerCase;
            }
            else if (upperLetters == word.Length)
            {
                return WordType.UpperCase;
            }
            return WordType.MixedCase;
        }
    }
}