using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace IndexofLetters
{
    class IndexofLetters
    {
        static void Main()
        {
            char[] word = File.ReadAllText("input.txt").ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
               File.AppendAllText("output.txt", $"{word[i]} -> {word[i] - 'a'}\r\n");
            }
        }
    }
}