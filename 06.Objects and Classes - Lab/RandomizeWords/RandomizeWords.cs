using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var rnd = new Random();

            for (int first = 0; first < words.Length; first++)
            {
                var second = rnd.Next(0, words.Length);
                var old = words[first];
                words[first] = words[second];
                words[second] = old;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}