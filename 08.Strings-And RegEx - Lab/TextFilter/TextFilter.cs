using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}