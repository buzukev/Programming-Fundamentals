using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var w in text)
            {
                if (counts.ContainsKey(w))
                {
                    counts[w]++;
                }
                else
                {
                    counts[w] = 1;
                }
            }
            var list = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                {
                    list.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", list));

            //variant two

            /*var text = Console.ReadLine().ToLower().Split(' ');
            Console.WriteLine(string.Join(", ", text.Where(x => text.Where(y => y == x).Count() % 2 == 1).Distinct));*/
        }
    }
}