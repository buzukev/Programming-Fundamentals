﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexofLetters
{
    public class IndexofLetters
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            char[] letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('a' + i);
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(letters, word[i])}");
            }

            //variant two
            /*char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {word[i] - 'a'}");
            }*/

            //variant three
            /*string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string input = Console.ReadLine();

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (input[j].ToString().Contains(alphabet[i]))
                    {
                        Console.WriteLine("{0} -> {1}", input[j], i);
                    }
                }
            }*/
        }
    }
}