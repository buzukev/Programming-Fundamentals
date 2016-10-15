using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordCount
{
    class WordCount
    {
        static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                wordsCount[words[i]] = 0;
            }
            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];

                if (wordsCount.ContainsKey(currentWord))
                {
                    wordsCount[currentWord]++;
                }
            }

            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", $"{word.Key} - {word.Value}{Environment.NewLine}");
            }
        }
    }
}