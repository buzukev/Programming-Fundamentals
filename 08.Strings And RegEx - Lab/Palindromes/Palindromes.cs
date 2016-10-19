using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (string word in text.Distinct().OrderBy(t => t))
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrome(string text)
        {
            bool isPalindrome = text == string.Join("", text.Reverse());

            /*bool isPalindrome = true;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (! text[i] != text[text.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }*/

            return isPalindrome;
        }
    }
}